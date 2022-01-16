using System;

namespace OpenClosed
{
    class Cook
    {
        public string Name { get; set; }
        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }




    class Cook2
    {
        public string Name { get; set; }

        public Cook2(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }

    interface IMeal
    {
        void Make();
    }

    class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }

    class SaladMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }
    }



    abstract class MealBase
    {
        public void Make()
        {
            Prepare();
            Cook();
            FinalSteps();
        }

        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void FinalSteps();
    }

    class PotatoMeal2 : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Варим около 30 минут");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Чистим и моем картошку");
        }
    }

    class SaladMeal2 : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Моем помидоры и огурцы");
        }
    }

    class Cook3
    {
        public string Name { get; set; }

        public Cook3(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(MealBase[] menu)
        {
            foreach (MealBase meal in menu)
                meal.Make();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cook bob = new Cook("Bob");
            bob.MakeDinner();

            Cook2 bob2 = new Cook2("Bob");
            bob2.MakeDinner(new PotatoMeal());
            Console.WriteLine();
            bob2.MakeDinner(new SaladMeal());

            MealBase[] menu = new MealBase[] { new PotatoMeal2(), new SaladMeal2() };
            Cook3 bob3 = new Cook3("Bob");
            bob3.MakeDinner(menu);
        }
    }
}
