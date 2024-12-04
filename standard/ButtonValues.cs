using CalcLib.Engine;
using CalcLib.Types;

namespace StandardCalc.Standard
{
    public class ButtonValues : IButtonValues
    {
        private readonly Item[,] _buttonItems = new Item[,] { };

        public ButtonValues()
        {
            Item _nnnn = NoneItem.CreateItem();

            Item Clear = Item.CreateItem("C", Methods.Clear());

            Item Calc = Item.CreateItem("=", Methods.Result());

            Item perc = Item.CreateItem("%", Methods.Percent());
            Item Inv = Item.CreateItem(((char)177).ToString(), Methods.Invert());

            Item Add = Item.CreateItem("+", Methods.Add());
            Item Div = Item.CreateItem("/", Methods.Division());
            Item Minus = Item.CreateItem("-", Methods.Minus());
            Item Multi = Item.CreateItem("*", Methods.Multiply());

            Item Sqrt = Item.CreateItem(((char)8730).ToString(), Methods.Sqrt());
            Item Square = Item.CreateItem("x²", Methods.Square());

            Item Comma = Item.CreateItem(",");

            Item Num0 = Item.CreateItem("0", 0);
            Item Num1 = Item.CreateItem("1", 1);
            Item Num2 = Item.CreateItem("2", 2);
            Item Num3 = Item.CreateItem("3", 3);
            Item Num4 = Item.CreateItem("4", 4);
            Item Num5 = Item.CreateItem("5", 5);
            Item Num6 = Item.CreateItem("6", 6);
            Item Num7 = Item.CreateItem("7", 7);
            Item Num8 = Item.CreateItem("8", 8);
            Item Num9 = Item.CreateItem("9", 9);


            _buttonItems = new Item[,]
            {
                { perc, _nnnn, Clear, _nnnn },
                { _nnnn, Square, Sqrt, Div },
                { Num7, Num8, Num9, Multi },
                { Num4, Num5, Num6, Minus },
                { Num1, Num2, Num3, Add },
                { Inv, Num0, Comma, Calc },
            };

            GetLengthY = _buttonItems.GetUpperBound(0);
            GetLengthX = _buttonItems.GetUpperBound(1);
            GetX = GetLengthX + 1;
        }

        public int GetLengthY { get; }

        public int GetLengthX { get; set; }

        public int GetX { get; }

        public Item GetItem(int y, int x)
        {
            return (Item)_buttonItems.GetValue(y, x);
        }
    }
}