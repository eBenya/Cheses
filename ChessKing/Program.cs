using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Посчитать сколькми способами можем добраться до i,j позиции на шахматной доске.
/// Фигура может перемещаться только вниз и вправо, если есть свободная клетка.
/// </summary>
namespace ChessKing
{
    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        public void Move()
        {
            Console.WriteLine("Move in BaseAction");
        }
    }
    class HeroAction : BaseAction, IAction
    {
        public new void Move()
        {
            Console.WriteLine("Move in HeroAction");
        }
    }
    class Program
    {
        private static int a = 0;
        const int HORIZ = 3;
        const int VERT = 3;
        static void Main(string[] args)
        {
            #region TEST
            BaseAction action1 = new HeroAction();
            action1.Move();            // Move in BaseAction

            IAction action2 = new HeroAction();
            action2.Move();             // Move in BaseAction
            Console.WriteLine();
            ((IAction)action1).Move();
            ((BaseAction)action1).Move();
            ((HeroAction)action1).Move();
            ((IAction)action2).Move();
            ((BaseAction)action2).Move();
            ((HeroAction)action2).Move();


            int sum = 0;//суммирование всех чисел выше 128
            for (int i = 0; i < 150; i+=10)
            {
                int t = (i - 128);
                    t = t >> 31;
                Console.WriteLine(t);
                sum += ~t & i;
            }
            #endregion

            //WRITE THIS:
            
        }        
    }
}

//sealed class Button
//{
//    internal delegate void Action();

//    internal event Action OnClick;

//    internal void FireClick()
//    {
//        OnClick();
//    }
//}

//public static class Program
//{
//    public static void Main()
//    {
//        Button ok = new Button();

//        Button.Action action = delegate
//        {
//            System.Console.Write("this is it!");
//        };

//        ok.OnClick += action;
//        ok.OnClick += action;

//        ok.FireClick();
//    }
//}