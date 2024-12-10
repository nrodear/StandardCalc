using LibCalc.Engine;
using LibCalc.Types;

namespace StandardCalc.standard
{
    public class ButtonValues : IButtonValues
    {
        private readonly Item[,] _buttonItems = new Item[,] { };

        public ButtonValues()
        {
            var none = NoneItem.CreateItem();

            var clear = Item.CreateItem("C", Methods.Clear());
            var calc = Item.CreateItem("=", Methods.Result());
            var percent = Item.CreateItem("%", Methods.Percent());
            var inv = Item.CreateItem(((char)177).ToString(), Methods.Invert());

            var add = Item.CreateItem("+", Methods.AddFunction());
            var div = Item.CreateItem("/", Methods.Division());
            var minus = Item.CreateItem("-", Methods.Minus());
            var multi = Item.CreateItem("*", Methods.Multiply());

            var sqrt = Item.CreateItem(((char)8730).ToString(), Methods.Sqrt());
            var square = Item.CreateItem("x²", Methods.Square());

            var comma = Item.CreateItem(".", Methods.Decimal());

            var num0 = Item.CreateItem("0", 0);
            var num1 = Item.CreateItem("1", 1);
            var num2 = Item.CreateItem("2", 2);
            var num3 = Item.CreateItem("3", 3);
            var num4 = Item.CreateItem("4", 4);
            var num5 = Item.CreateItem("5", 5);
            var num6 = Item.CreateItem("6", 6);
            var num7 = Item.CreateItem("7", 7);
            var num8 = Item.CreateItem("8", 8);
            var num9 = Item.CreateItem("9", 9);


            _buttonItems = new Item[,]
            {
                { percent, none, clear, none },
                { none, square, sqrt, div },
                { num7, num8, num9, multi },
                { num4, num5, num6, minus },
                { num1, num2, num3, add },
                { inv, num0, comma, calc },
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