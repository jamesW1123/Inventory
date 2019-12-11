using Inventory.Objects;
using Inventory.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.API
{
    static class Transaction
    {
        /// <summary>
        /// Add a quantity of one to an item in inventory.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public static bool Add_Item(int barcode)
        {
            Item i = new Item(barcode, true);

            if (i.updateQuantity(i.Onhand + 1)) return true;
            return false;
        }

        /// <summary>
        /// Add a quantity of X to an item in inventory.
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static bool Add_Item(int barcode, int quantity)
        {
            Item i = new Item(barcode, true);

            if (i.updateQuantity(i.Onhand + quantity)) return true;
            return false;
        }

        /// <summary>
        /// Remove a quantity of one from an item in inventory.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public static bool Remove_Item(int barcode)
        {
            Item i = new Item(barcode, true);

            if (i.Onhand > 0)
            {
                if (i.updateQuantity(i.Onhand - 1)) return true;
                return false;
            }

            return false;
        }

        /// <summary>
        /// Remove a quantity of X from an item in inventory.
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static bool Remove_Item(int barcode, int quantity)
        {
            Item i = new Item(barcode, true);

            if (i.Onhand >= quantity)
            {
                if (i.updateQuantity(i.Onhand - quantity)) return true;
                return false;
            }

            return false;
        }

        /// <summary>
        /// Returns a comma seperated string of all fields of an item.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns ></returns>
        public static string Get_Item_Details(int barcode)
        {
            Item i = new Item(barcode, true);
            return i.ToString(i);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public static int Get_Onhand(int barcode)
        {
            int result = 0;
            Item i = new Item(barcode, true);

            result = i.Onhand;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public static int Get_Onorder(int barcode)
        {
            int result = 0;
            Item i = new Item(barcode, true);

            result = i.Onorder;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public static decimal Get_Cost_Price(int barcode)
        {
            decimal result = 0;
            Item i = new Item(barcode, true);

            result = i.Sell;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public static decimal Get_Sell_Price(int barcode)
        {
            decimal result = 0;
            Item i = new Item(barcode, true);

            result = i.Sell;

            return result;
        }
    }
}
