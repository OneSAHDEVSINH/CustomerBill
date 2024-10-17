using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    internal class Customer
    {
        private string _name;
        private int _units;
        private float _totalBill, _remains;

        public void SetName(string name)
        {
            _name = name;
        }

        public int Units
        {
            set
            {
                _units = value;
            }
        }

        public float Remains
        {
            set
            {
                _remains = value;
            }
        }

        public void CalculateBill()
        {
            if (_units <= 100)
            {
                _totalBill = _units * 2.5f;
            }
            else
            {
                _totalBill = 100 * 2.5f;
                _remains = _units - 100;
                if (_remains <= 200)
                {
                    _totalBill += _remains * 3.5f;
                }
                else
                {
                    _totalBill = 200 * 3.5f;
                    _remains -= 200;
                    _totalBill += _remains * 4.5f;
                    
                }
            }
        }

        public Tuple<string, int, float, float> GetData()
        {
            return new Tuple<string, int, float, float>(_name, _units, _remains, _totalBill);
        }
    }
}
