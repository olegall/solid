namespace Liskov
{
    class MSDN
    {
        //class Mammal { }

        //class Nerd : Mammal
        //{
        //    public double Diopter { get; protected set; }

        //    public Nerd(int vertebrae, double diopter) : base(vertebrae) { Diopter = diopter; }

        //    protected Nerd(Nerd toBeCloned) : base(toBeCloned) { Diopter = toBeCloned.Diopter; }

        //    // Предпочел бы возвращать Nerd:
        //    // public override Mammal Clone() { return new Nerd(this); }
        //    public new Nerd Clone() { return new Nerd(this); }
        //}

        /*
        Код на рис. 3 показывает, как может быть нарушена возможность подстановки. Всегда тщательно продумывайте производные классы. 
        Один из них может по случайности модифицировать поле isMoonWalking, как в этом примере. Если это случится, базовый класс рискует лишиться критической секции очистки. 
        Поле isMoonWalking должно быть закрытым. Если о нем должны знать производные классы, предусмотрите для него защищенное свойство с аксессором get для его чтения, но не для изменения.
         */

        class Control { }
        class MouseButtonEventArgs { }

        //class GrooveControl : Control
        //{
        //    protected bool isMoonWalking;

        //    protected override void OnMouseDown(MouseButtonEventArgs e)
        //    {
        //        isMoonWalking = CaptureMouse();
        //        base.OnMouseDown(e);
        //    }

        //    protected override void OnMouseUp(MouseButtonEventArgs e)
        //    {
        //        base.OnMouseUp(e);
        //        if (isMoonWalking)
        //        {
        //            ReleaseMouseCapture();
        //            isMoonWalking = false;
        //        }
        //    }
        //}
    }
}
