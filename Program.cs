using System;

namespace SayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int o = 1;
            int kactahmin = 1;
            while (o > 0)
            {
                Console.WriteLine("oyun zorluğunu seç !\n" +
                                "(1)>> 1 ile 10 arası\n" +
                                "(2)>> 1 ile 100 arası\n" +
                                "(3)>> 1 ile 500 arası\n" +
                                "(4)>> 1 ile 1000 arası\n" +
                                "(x)>> Çıkış Yap");

                Console.Write("seçimin : ");
                string secim =Console.ReadLine();

                if (secim == "1")
                {
                    Random rndm = new Random();
                    int random = rndm.Next(1, 11);
                    int l = 1;
                    while (l > 0)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.Write("1 ile 10 arasında bir sayı tahmin et : ");
                        int tahmin = Convert.ToInt32(Console.ReadLine());

                        if (tahmin > 10 || tahmin < 1)
                        {
                            Console.WriteLine("Lütfen 1 ile 10 arası bir sayı giriniz !");
                        }
                        else
                        {

                            if (tahmin < random)
                            {
                                Console.WriteLine("tahminin Küçük !");
                                kactahmin++;
                            }
                            else if (tahmin > random)
                            {
                                Console.WriteLine("tahminin Büyük !");
                                kactahmin++;
                            }
                            else
                            {

                                if (kactahmin != 1)
                                {
                                    Console.WriteLine($"{kactahmin} defa tahmin ederek oyunu kazandın !");
                                    Console.WriteLine($"Daha iyisini yapabilir misin ?");
                                    Console.WriteLine("Tekrar Dene !");
                                }
                                else
                                {
                                    Console.WriteLine("Tekte tahmin ederek oyunu kazandın !");
                                    Console.WriteLine("HARİKASIN !");
                                    Console.WriteLine("Bir kez Daha !");
                                }

                                Console.WriteLine("---------------------------------------");

                                break;
                            }
                        }

                    }


                }
                else if (secim == "2")
                {
                    Random rndm = new Random();
                    int random = rndm.Next(1, 101);
                    int l = 1;
                    
                    while (l > 0)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.Write("1 ile 100 arasında bir sayı tahmin et : ");
                        int tahmin = Convert.ToInt32(Console.ReadLine());

                        if (tahmin > 100 || tahmin < 1)
                        {
                            Console.WriteLine("Lütfen 1 ile 100 arası bir sayı giriniz !");
                        }
                        else
                        {

                            if (tahmin < random)
                            {
                                Console.WriteLine("tahminin Küçük !");
                                kactahmin++;
                            }
                            else if (tahmin > random)
                            {
                                Console.WriteLine("tahminin Büyük !");
                                kactahmin++;
                            }
                            else
                            {

                                if (kactahmin != 1)
                                {
                                    Console.WriteLine($"{kactahmin} defa tahmin ederek oyunu kazandın !");
                                    Console.WriteLine($"Daha iyisini yapabilir misin ?");
                                    Console.WriteLine("Tekrar Dene !");
                                }
                                else
                                {
                                    Console.WriteLine("Tekte tahmin ederek oyunu kazandın !");
                                    Console.WriteLine("HARİKASIN !");
                                    Console.WriteLine("Bir kez Daha !");
                                }

                                Console.WriteLine("---------------------------------------");

                                break;
                            }
                        }

                    }
                }
                else if (secim == "3")
                {
                    Random rndm = new Random();
                    int random = rndm.Next(1, 501);
                    int l = 1;
                    
                    while (l > 0)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.Write("1 ile 500 arasında bir sayı tahmin et : ");
                        int tahmin = Convert.ToInt32(Console.ReadLine());

                        if (tahmin > 500 || tahmin < 1)
                        {
                            Console.WriteLine("Lütfen 1 ile 500 arası bir sayı giriniz !");
                        }
                        else
                        {

                            if (tahmin < random)
                            {
                                Console.WriteLine("tahminin Küçük !");
                                kactahmin++;
                            }
                            else if (tahmin > random)
                            {
                                Console.WriteLine("tahminin Büyük !");
                                kactahmin++;
                            }
                            else
                            {

                                if (kactahmin != 1)
                                {
                                    Console.WriteLine($"{kactahmin} defa tahmin ederek oyunu kazandın !");
                                    Console.WriteLine($"Daha iyisini yapabilir misin ?");
                                    Console.WriteLine("Tekrar Dene !");
                                }
                                else
                                {
                                    Console.WriteLine("Tekte tahmin ederek oyunu kazandın !");
                                    Console.WriteLine("HARİKASIN !");
                                    Console.WriteLine("Bir kez Daha !");
                                }

                                Console.WriteLine("---------------------------------------");

                                break;
                            }
                        }

                    }
                }
                else if (secim == "4")
                {
                    Random rndm = new Random();
                    int random = rndm.Next(1, 1001);
                    int l = 1;
                    
                    while (l > 0)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.Write("1 ile 1000 arasında bir sayı tahmin et : ");
                        int tahmin = Convert.ToInt32(Console.ReadLine());

                        if (tahmin > 1000 || tahmin < 1)
                        {
                            Console.WriteLine("Lütfen 1 ile 1000 arası bir sayı giriniz !");
                        }
                        else
                        {

                            if (tahmin < random)
                            {
                                Console.WriteLine("tahminin Küçük !");
                                kactahmin++;
                            }
                            else if (tahmin > random)
                            {
                                Console.WriteLine("tahminin Büyük !");
                                kactahmin++;
                            }
                            else
                            {

                                if (kactahmin != 1)
                                {
                                    Console.WriteLine($"{kactahmin} defa tahmin ederek oyunu kazandın !");
                                    Console.WriteLine($"Daha iyisini yapabilir misin ?");
                                    Console.WriteLine("Tekrar Dene !");
                                }
                                else
                                {
                                    Console.WriteLine("Tekte tahmin ederek oyunu kazandın !");
                                    Console.WriteLine("HARİKASIN !");
                                    Console.WriteLine("Bir kez Daha !");
                                }

                                Console.WriteLine("---------------------------------------");

                                break;
                            }
                        }

                    }
                }
                else if (secim == "x")
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Çıkış Yaptın :)\n" +
                        "Yine Beklerim..");
                    return;
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Tekrar Deneyin !");
                    Console.WriteLine("---------------------------------------");
                }
            }




        }
    }
}
