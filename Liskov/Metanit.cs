using System;

namespace Liskov
{
    class Metanit
    {
        public class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public int GetArea()
            {
                return Width * Height;
            }
        }

        public class Square : Rectangle
        {
            public override int Width
            {
                get
                {
                    return base.Width;
                }

                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }

            public override int Height
            {
                get
                {
                    return base.Height;
                }

                set
                {
                    base.Height = value;
                    base.Width = value;
                }
            }
        }

        public static void TestRectangleArea(Rectangle rect)
        {
            rect.Height = 5;
            rect.Width = 10;
            if (rect.GetArea() != 50)
                throw new Exception("Некорректная площадь!");
        }

        public class Account
        {
            public int Capital { get; protected set; }

            public virtual void SetCapital(int money)
            {
                if (money < 0)
                    throw new Exception("Нельзя положить на счет меньше 0");
                this.Capital = money;
            }

            public virtual decimal GetInterest(decimal sum, int month, int rate)
            {
                // предусловие
                if (sum < 0 || month > 12 || month < 1 || rate < 0)
                    throw new Exception("Некорректные данные");

                decimal result = sum;
                for (int i = 0; i < month; i++)
                    result += result * rate / 100;

                // постусловие
                if (sum >= 1000)
                    result += 100; // добавляем бонус

                return result;
            }
        }

        public class MicroAccount : Account
        {
            public override void SetCapital(int money)
            {
                if (money < 0)
                    throw new Exception("Нельзя положить на счет меньше 0");

                if (money > 100)
                    throw new Exception("Нельзя положить на счет больше 100");

                this.Capital = money;
            }

            public override decimal GetInterest(decimal sum, int month, int rate)
            {
                if (sum < 0 || month > 12 || month < 1 || rate < 0)
                    throw new Exception("Некорректные данные");

                decimal result = sum;
                for (int i = 0; i < month; i++)
                    result += result * rate / 100;

                // убрали постусловие

                return result;
            }
        }

        public static void InitializeAccount(Account account)
        {
            account.SetCapital(200);
            Console.WriteLine(account.Capital);
        }

        public static void CalculateInterest(Account account)
        {
            decimal sum = account.GetInterest(1000, 1, 10); // 1000 + 1000 * 10 / 100 + 100 (бонус)
            if (sum != 1200) // ожидаем 1200
            {
                throw new Exception("Неожиданная сумма при вычислениях");
            }
        }
    }
}
