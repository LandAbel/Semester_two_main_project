using System;
using System.Globalization;

namespace Semester_two_main_project
{
    static class Randgen
    {
        public static Random randint = new Random();
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Test2();
            Test1();
        }
        static void Test1()
        {
            try
            {
                //Gryffindor-Bravery, Ravenclaw- Intelligence, Hufflepuff-Empathy, Slytherin-Ambition
                BinaryTree<string, int> Gryffindor = new BinaryTree<string, int>();
                BinaryTree<string, int> Ravenclaw = new BinaryTree<string, int>();
                BinaryTree<string, int> Hufflepuff = new BinaryTree<string, int>();
                BinaryTree<string, int> Slytherin = new BinaryTree<string, int>();
                IfjoncVar[] magicians = new IfjoncVar[26];
                magicians[0] = new IfjoncVar(1, 15, 21, 14);//huff
                magicians[1] = new IfjoncVar(2, 12, 11, 27);//slyt
                magicians[2] = new IfjoncVar(3, 12, 15, 12);//huff
                magicians[3] = new IfjoncVar(4, 18, 13, 19);//slyt
                magicians[4] = new IfjoncVar(5, 19, 8, 13);//rav
                magicians[5] = new IfjoncVar(6, 13, 9, 12);//rav
                magicians[6] = new IfjoncVar(7, 11, 7, 9);//rav
                magicians[7] = new IfjoncVar(8, 10, 6, 8);//rav
                magicians[8] = new IfjoncVar(9, 7, 5, 6);//griff
                magicians[9] = new IfjoncVar(10, 9, 4, 7);//griff
                magicians[10] = new IfjoncVar(11, 6, 4, 5);//griff
                magicians[11] = new IfjoncVar(15, 7, 18, 4);//huff
                magicians[12] = new IfjoncVar(15, 2, 16, 3);//huff
                magicians[13] = new IfjoncVar(14, 1, 2, 2);//griff
                magicians[14] = new IfjoncVar(15, 5, 2, 1);//griff
                magicians[15] = new IfjoncVar(1, 15, 20, 14);//huff
                magicians[16] = new IfjoncVar(10, 11, 12, 29);//slyt
                magicians[17] = new IfjoncVar(3, 12, 19, 12);//huff
                magicians[18] = new IfjoncVar(12, 19, 15, 22);//slyt
                magicians[19] = new IfjoncVar(15, 28, 8, 13);//rav
                magicians[20] = new IfjoncVar(6, 17, 9, 12);//rav
                magicians[21] = new IfjoncVar(10, 12, 7, 9);//rav
                magicians[22] = new IfjoncVar(12, 10, 6, 28);//slyt
                magicians[23] = new IfjoncVar(22, 7, 5, 6);//griff
                magicians[24] = new IfjoncVar(10, 9, 4, 17);//slyt
                magicians[25] = new IfjoncVar(2, 6, 4, 12);//slyt
                magicians[24] = new IfjoncVar(10, 8, 22, 14);//huff
                magicians[25] = new IfjoncVar(30, 20, 20, 20, "Harry Potter");//griff
                Console.WriteLine("Adjon meg egy tulajdonságot(angolul) és egy értéket:");
                string[] helpper = Console.ReadLine().Split();
                string name = helpper[0];
                int power = int.Parse(helpper[1]);
                string temp = "";
                string temp2 = "";
                string temp3 = "";
                string temp4 = "";
                for (int l = 0; l < magicians.Length; l++)
                {

                    int[] help = { magicians[l].Bravery, magicians[l].Intelligence, magicians[l].Empathy, magicians[l].Ambition };
                    int idx = 0;
                    for (int j = 1; j < help.Length; j++)
                    {
                        if (help[j] > help[idx])
                        {
                            idx = j;
                        }
                    }
                    if (idx == 0)
                    {
                        Gryffindor.Add(magicians[l].Name, magicians[l].Bravery);
                        temp += DecesionMaker(magicians[l], name, power);
                    }
                    else if (idx == 1)
                    {
                        Ravenclaw.Add(magicians[l].Name, magicians[l].Intelligence);
                        temp2 += DecesionMaker(magicians[l], name, power);

                    }
                    else if (idx == 2)
                    {
                        Hufflepuff.Add(magicians[l].Name, magicians[l].Empathy);
                        temp3 += DecesionMaker(magicians[l], name, power);
                    }
                    else if (idx == 3)
                    {
                        Slytherin.Add(magicians[l].Name, magicians[l].Empathy);
                        temp4 += DecesionMaker(magicians[l], name, power);
                    }
                }
                ButyPrinter(temp, "Gryffindor");
                ButyPrinter(temp2, "Ravenclaw");
                ButyPrinter(temp3, "Hufflepuff");
                ButyPrinter(temp4, "Slytherin");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Test2()
        {
            try
            {
                //Gryffindor-Bravery, Ravenclaw- Intelligence, Hufflepuff-Empathy, Slytherin-Ambition
                BinaryTree<string, int> Gryffindor = new BinaryTree<string, int>();
                BinaryTree<string, int> Ravenclaw = new BinaryTree<string, int>();
                BinaryTree<string, int> Hufflepuff = new BinaryTree<string, int>();
                BinaryTree<string, int> Slytherin = new BinaryTree<string, int>();
                IfjoncVar[] magicians = new IfjoncVar[26];
                magicians[0] = new IfjoncVar(1, 15, 21, 14);//huff
                magicians[1] = new IfjoncVar(2, 12, 11, 27);//slyt
                magicians[2] = new IfjoncVar(3, 12, 15, 12);//huff
                magicians[3] = new IfjoncVar(4, 18, 13, 19);//slyt
                magicians[4] = new IfjoncVar(5, 19, 8, 13);//rav
                magicians[5] = new IfjoncVar(6, 13, 9, 12);//rav
                magicians[6] = new IfjoncVar(7, 11, 7, 9);//rav
                magicians[7] = new IfjoncVar(8, 10, 6, 8);//rav
                magicians[8] = new IfjoncVar(9, 7, 5, 6);//griff
                magicians[9] = new IfjoncVar(10, 9, 4, 7);//griff
                magicians[10] = new IfjoncVar(11, 6, 4, 5);//griff
                magicians[11] = new IfjoncVar(15, 7, 18, 4);//huff
                magicians[12] = new IfjoncVar(15, 2, 16, 3);//huff
                magicians[13] = new IfjoncVar(14, 1, 2, 2);//griff
                magicians[14] = new IfjoncVar(15, 5, 2, 1);//griff
                magicians[15] = new IfjoncVar(1, 15, 20, 14);//huff
                magicians[16] = new IfjoncVar(10, 11, 12, 29);//slyt
                magicians[17] = new IfjoncVar(3, 12, 19, 12);//huff
                magicians[18] = new IfjoncVar(12, 19, 15, 22);//slyt
                magicians[19] = new IfjoncVar(15, 28, 8, 13);//rav
                magicians[20] = new IfjoncVar(6, 17, 9, 12);//rav
                magicians[21] = new IfjoncVar(10, 12, 7, 9);//rav
                magicians[22] = new IfjoncVar(12, 10, 6, 28);//slyt
                magicians[23] = new IfjoncVar(22, 7, 5, 6);//griff
                magicians[24] = new IfjoncVar(10, 9, 4, 17);//slyt
                magicians[25] = new IfjoncVar(2, 6, 4, 12);//slyt
                magicians[24] = new IfjoncVar(10, 8, 22, 14);//huff
                magicians[25] = new IfjoncVar(30, 20, 20, 20, "Harry Potter");//griff
                for (int l = 0; l < magicians.Length; l++)
                {
                    int[] help = { magicians[l].Bravery, magicians[l].Intelligence, magicians[l].Empathy, magicians[l].Ambition };
                    int idx = 0;
                    for (int j = 1; j < help.Length; j++)
                    {
                        if (help[j] > help[idx])
                        {
                            idx = j;
                        }
                    }
                    if (idx == 0)
                    {
                        Gryffindor.Add(magicians[l].Name, magicians[l].Bravery);
                    }
                    else if (idx == 1)
                    {
                        Ravenclaw.Add(magicians[l].Name, magicians[l].Intelligence);
                    }
                    else if (idx == 2)
                    {
                        Hufflepuff.Add(magicians[l].Name, magicians[l].Empathy);
                    }
                    else if (idx == 3)
                    {
                        Slytherin.Add(magicians[l].Name, magicians[l].Empathy);
                    }
                }
                Console.WriteLine(Gryffindor.Search(30));
                Console.WriteLine("\r\nGryffindor:\r\n");
                Gryffindor.InOrder();
                Console.WriteLine("\r\nRavenclaw:\r\n");
                Ravenclaw.InOrder();
                Console.WriteLine("\r\nHufflepuff:\r\n");
                Hufflepuff.InOrder();
                Console.WriteLine("\r\nSlytherin:\r\n");
                Slytherin.InOrder();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static string DecesionMaker(IfjoncVar magicians, string name, int power)
        {
            if (name == "Bravery")
            {
                if (magicians.Bravery >= power)
                {
                    //Console.WriteLine($"Magican from {house} has a bravery of {power}: {magicians.Name}");
                    return $":{magicians.Name}:";
                }
            }
            else if (name == "Intelligence")
            {
                if (magicians.Intelligence >= power)
                {
                    //Console.WriteLine($"Magician from {house} has an intelligence of {power}: {magicians.Name}");
                    return $":{magicians.Name}:";
                }
            }
            else if (name == "Empathy")
            {
                if (magicians.Empathy >= power)
                {
                    //Console.WriteLine($"Magician from {house} has a empathy {power}: {magicians.Name}");
                    return $":{magicians.Name}:";
                }
            }
            else if (name == "Ambition")
            {
                if (magicians.Ambition >= power)
                {
                    //Console.WriteLine($"Magician from {house} has an ambition of {power}: {magicians.Name}");
                    return $":{magicians.Name}:";
                }
            }
            return "";
        }
        static void ButyPrinter(string temp, string house)
        {
            string[] tempp = temp.Split(":");
            Console.WriteLine($"{house}:");
            for (int i = 0; i < tempp.Length; i++)
            {
                Console.Write($"{tempp[i]}");
                Console.WriteLine();
            }
        }
    }
    class IfjoncVar
    {
        string[] First = { "Harry", "Draco", "Hermione", "Luna", "Albus", "James", "Luna", "Bill", "George", "Seamus", "Gellert", "Sirius", "Lily", "Nicolas" };
        string[] Last = { "Potter", "Voldemort", "Dumbledore", "Hagrid", "Malfoy", "Granger", "Lovegood", "Weasley", "Flamel", "Finnigan", "Black", "Filch", "Delacour", "McGonagall" };
        public int Bravery { get; set; }
        public int Intelligence { get; set; }
        public int Empathy { get; set; }
        public int Ambition { get; set; }
        public string Name { get; set; }
        public IfjoncVar(int batorsag, int intelligencia, int kitartas, int ravaszsag)
        {
            Bravery = batorsag;
            Intelligence = intelligencia;
            Empathy = kitartas;
            Ambition = ravaszsag;
            Name = $"{First[Randgen.randint.Next(0, First.Length - 1)]} {Last[Randgen.randint.Next(0, Last.Length - 1)]}";
        }
        public IfjoncVar(int bravery, int intelligence, int empathy, int ambition, string name) : this(bravery, intelligence, empathy, ambition)
        {
            Name = name;
        }
    }
    class BinaryTree<T, K> where K : IComparable
    {
        class TreeItem
        {
            public T content;
            public K key;
            public TreeItem left;
            public TreeItem right;
        }
        private TreeItem Root;

        public void Add(T content, K key)
        {
            _Add(ref Root, content, key);
        }
        private void _Add(ref TreeItem p, T content, K key)
        {
            if (p == null)
            {
                p = new TreeItem();
                p.content = content;
                p.key = key;
            }
            else
            {
                if (p.key.CompareTo(key) < 0)
                {
                    //to the right side
                    _Add(ref p.right, content, key);
                }
                else if (p.key.CompareTo(key) > 0)
                {
                    //to the left side
                    _Add(ref p.left, content, key);
                }
                else
                {
                    throw new ArgumentException("This item is already in the tree!");
                }
            }
        }

        private void _InOrder(TreeItem p)
        {
            if (p != null)
            {
                _InOrder(p.left);
                Console.WriteLine(p.content);
                _InOrder(p.right);
            }
        }
        public void InOrder()
        {
            _InOrder(Root);
        }
        public T Search(K key)
        {
            return _Search(Root, key);
        }
        private T _Search(TreeItem p, K key)
        {
            if (p != null)
            {
                if (p.key.CompareTo(key) < 0)
                {
                    //right
                    return _Search(p.right, key);
                }
                else if (p.key.CompareTo(key) > 0)
                {
                    //left
                    return _Search(p.left, key);
                }
                else
                {
                    //key== our key
                    return p.content;
                }
            }
            else
            {
                throw new ArgumentException($"There is no item in the tree by this name {p.content}");
            }
        }

    }

}