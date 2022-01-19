using System;

namespace Lab02_Bai1
{
    class MainClass
    {
        public static Node head = null;

        public static void Main(string[] args)
        {
            int number = 0;

            infor();

            do
            {
                Console.Write("Chon: ");
                number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("Thoat");
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Da khoi tao danh sach");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        print();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        int n = 0;
                        Console.Write("Nhap so: ");
                        n = int.Parse(Console.ReadLine());
                        insertTail(n);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        removeHead();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.Write("Nhap so: ");
                        int a = int.Parse(Console.ReadLine());
                        remove(a);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.Write("Nhap: ");
                        int nb = int.Parse(Console.ReadLine());
                        search(nb);
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        max();
                        Console.WriteLine();
                        break;
                }
            } while (number >= 1 && number <= 7);
        }
        static void max()
        {
            Node p = head;
            int max;
            max = p.data;
            while (p != null)
            {
                if (max < p.data)
                {
                    max = p.data;
                }
                p = p.next;
            }
            Console.WriteLine("Max: {0}", max);
        }

        static void search(int n)
        {
            Node p = head;
            Node q = head;
            while (q.data != n)
            {
                p = q;
                q = q.next;
            }
            p.next = q.next;
            Console.WriteLine(q.data);
        }

        static void infor()
        {
            Console.WriteLine("\t--------");
            Console.WriteLine("1. Tao danh sach");
            Console.WriteLine("2. Duyet danh sach");
            Console.WriteLine("3. Them phan tu vao danh sach");
            Console.WriteLine("4. Xoa phan tu dau danh sach");
            Console.WriteLine("5. Xoa phan tu ra danh sach");
            Console.WriteLine("6. Tim kiem phan tu");
            Console.WriteLine("7. Tim phan tu lon nhat");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("\t--------\n");
        }

        static void print()
        {
            Node a = head;
            if (head == null)
            {
                Console.WriteLine("...");
            }
            else
            {
                Console.WriteLine(a.data);
                while (a.next != null)
                {
                    a = a.next;
                    Console.WriteLine(a.data);
                }
            }
        }

        static void insertTail(int n)
        {
            Node node = new Node(n);
            Node temp = null;

            if (head == null)
            {
                head = node;
            }
            else
            {
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        static void removeHead()
        {
            if (head != null)
            {
                head = head.next;
            }
        }

        static void remove(int a)
        {
            Node p = head;
            Node q = head;
            while (q.data != a)
            {
                p = q;
                q = q.next;
            }
            p.next = q.next;
            q.next = null;
        }
    }
}