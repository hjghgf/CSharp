using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ege
{
    class Task2475
    {
        class Tree
        {
            class Node
            {
                char gamer = 'P';
                public int card = 0;
                List<Node> nodes = new List<Node>();
                List<int> cards = null;

                public Node(char gamer, int card, List<int> cards)
                {
                    this.gamer = gamer;
                    this.card = card;
                    this.cards = cards;

                    if (gamer == 'P')
                    {
                        gamer = 'V';
                    }
                    else
                    {
                        gamer = 'P';
                    }
                    foreach (var newCard in new HashSet<int>(cards))
                    {
                        if (newCard == this.card || newCard == this.card + 1)
                        {
                            var newCards = new List<int>(cards);
                            newCards.Remove(newCard);
                            nodes.Add(new Node(gamer, newCard, newCards));
                        }
                    }
                }

                public bool T19()
                {
                    if (nodes.Count == 0)
                    {
                        return gamer == 'P';
                    }

                    if (gamer == 'V')
                    {
                        bool res = false;
                        foreach (var node in nodes)
                        {
                            res = res || node.T19();
                        }

                        return res;
                    }
                    else
                    {
                        bool res = true;
                        foreach (var node in nodes)
                        {
                            res = res && node.T19();
                        }

                        return res;
                    }
                }
            }

            List<Node> root = new List<Node>();

            public Tree(List<int> cards)
            {
                char gamer = 'P';
                foreach (var newCard in new HashSet<int>(cards))
                {
                    var newCards = new List<int>(cards);
                    newCards.Remove(newCard);
                    root.Add(new Node(gamer, newCard, newCards));
                }
            } 

            public List<int> T19()
            {
                var ans = new List<int>();
                foreach (var node in root)
                {
                    if (node.T19())
                    {
                        ans.Add(node.card);
                    }
                }

                return ans;
            }
        }

        static List<List<int>> GenerateList()
        {
            var arrays = new List<List<int>>();
            
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        for (int l = 1; l <= 4; l++)
                        {
                            arrays.Add(new List<int> { i, j, k, l });
                        }
                    }
                }
            }

            Console.WriteLine();
            return arrays;
        }

        public int Combinations(List<List<int>> combinations)
        {
            int ans = 0;
            foreach (var item in combinations)
            {
                var tr = new Tree(item);

            }

            return ans;
        }

        public static void Run()
        {
            //var cards = new List<int> { 5, 6, 6, 7, 7, 7, 8, 9, 9, 9, 10, 10 };
            //var tr = new Tree(cards);
            //var ans = tr.T19();
            //Console.ReadKey();

            var res = GenerateList();
            Console.ReadKey();
        }
    }
}
