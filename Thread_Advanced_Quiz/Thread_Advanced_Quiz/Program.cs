﻿using System;

using System.Threading;



namespace Thread_Advanced_Quiz
{
    public class Cake
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Chef
    {
        // 케익을 만드는 메서드를 추가하세요. 이 메서드는 케익을 만드는 데 1초가 걸립니다.
        private object _lock = new object();
        public Cake BakeCake(string name, double price)
        {
            lock (_lock)
            {
                Console.WriteLine($"주방장이 {name} 케익을 만들기 시작했습니다.");
                Thread.Sleep(1000);
                Console.WriteLine($"{name} 케익이 완성되었습니다!");
                return new Cake { Name = name, Price = price };
            }
        }
    }
    public class Customer
    {
        // 케익 주문 메서드를 추가하세요. 주문이 들어오면 Chef가 케익을 만들기 시작하고, 케익이 완성되면 케익을 받습니다.
        public void OrderCake(Chef chef, string name, double price)
        {
            //여기에 코딩하세요.
            Console.WriteLine($"손님이 {name} 케익을 주문했습니다.");
            Cake cake = chef.BakeCake(name, price);
            Console.WriteLine($"손님이 {cake.Name} 케익을 받았습니다!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Chef chef = new Chef();
            Customer customer = new Customer();
            Thread[] threads = new Thread[5];

            // 여기에서 주문과 케익 제작 프로세스를 코딩하세요.
            for (int i = 0; i < 5; i++)
            {
                string cakeName = $"케익 {i}";
                double cakePrice = 10.0 * (i + 1);

                threads[i] = new Thread(() => customer.OrderCake(chef, cakeName, cakePrice));
                threads[i].IsBackground = true;
                threads[i].Start();
            }

            // 모든 스레드가 완료될 때까지 기다림
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("모든 케익 주문이 완료되었습니다.");
        }
    }
}