using GiftStore.Comparers;
using GiftStore.Infrastructure;
using GiftStore.Infrastructure.SweetnessFactory;
using GiftStore.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GiftStore
{
    class Program
    {
        static private ICandyGift<Sweetness> _candyGift;

        static void Main(string[] args)
        {
            _candyGift = new NewGift<Sweetness>();
            StartApp();
        }

        static private void StartApp()
        {
            var sweetnesses = FillGift();
            _candyGift.AddSweetness(sweetnesses);
            ShowGiftContent($"\nThe gift weight - {_candyGift.GetGiftWeight()} gr.\n");

            while (true)
            {
                WorkMenu();
            }
        }

        static private IEnumerable<Sweetness> FillGift()
        {
            Random random = new Random();
            int sweetnessCount = random.Next(5, 10);
            Factory[] factories = new Factory[]
            {
                new CandyCreator(),
                new ChocolateBarCreator(),
                new JellyCandyCreator()
            };

            for (int i = 0; i < sweetnessCount; i++)
            {
                int index = random.Next(0, factories.Length);
                yield return factories[index].CreateSweetness();
            }
        }

        static private void WorkMenu()
        {
            Console.Write("\nOptions menu:\n\t1. Get sweetness by sugar content.\n\t2. Sort by 'name'.\n\t3. Sort by 'manufacturer'.\n\t4. Sort by 'sugar content'.\n" +
                "\t5. Sort by 'weight'.\n\t6. Sort by 'taste'.\n\t7. Sort by 'percentage cocoa content'.\n\t8. Sort by 'thickening agent'.\n\tOr enter any button to exit.\nYour choice? ");
            int userChoise;
            int.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out userChoise);

            switch (userChoise)
            {
                case 1: { FindSweetness(); break; }
                case 2: { Sort(x => x.Name); break; }
                case 3: { Sort(x => x.Manufacturer); break; }
                case 4: { Sort(x => x.SugarContent); break; }
                case 5: { Sort(x => x.Weight); break; }
                case 6: { Sort<Candy>(new CandyTasteComarer()); break; }
                case 7: { Sort<ChocolateBar>(new ChocolateBarCocoaContentComparer()); break; }
                case 8: { Sort<JellyCandy>(new JellyCandyThickeningAgentComparer()); break; }
                default:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }

        static private void FindSweetness()
        {
            Console.Write("Minimum sugar content: ");
            float min;
            float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out min);

            Console.Write("Maximum sugar content: ");
            float max;
            float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out max);

            var sweetness = _candyGift.FindSweetnessBySugarContent(min, max);
            if (sweetness != null)
            {
                ShowGiftContent($"\nFound: {sweetness.GetSweetnessInfo()}\n");
            }
            else
            {
                ShowGiftContent("\nNo sweets found.\n");
            }
        }

        static private void Sort<T>(Func<Sweetness, T> func)
        {
            if (func is null)
            {
                throw new ArgumentNullException("parameter 'func' cannot be null!");
            }

            _candyGift.SortSweetness(func);
            ShowGiftContent();
        }

        static private void Sort<T>(IComparer<object> comparer)
        {
            if (comparer is null)
            {
                throw new ArgumentNullException("parameter 'comparer' cannot be null!");
            }

            _candyGift.SortSweetness<T>(comparer);
            ShowGiftContent();
        }

        static private void ShowGiftContent(string note = null)
        {
            Console.Clear();
            foreach (var sweetness in _candyGift.Sweetnesses)
            {
                Console.WriteLine(sweetness.GetSweetnessInfo());
            }

            Console.Write(note);
        }
    }
}
