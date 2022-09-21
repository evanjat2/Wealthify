using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    internal class Keuangan
    {
        private string _jenisKeuangan;
        private string _kategoriKeuangan;
        private float _saldo;
        private float _targetTabungan;
      public string jenisKeuangan
      {
        get { return _jenisKeuangan; }
        set { _jenisKeuangan = value; }
      }
      public string kategoriKeuangan
      {
        get { return _kategoriKeuangan; }
        set { _kategoriKeuangan = value; }
      }
      public float saldo
      {
        get { return _saldo; }
        set { _saldo = value; }
      }
      public float targetTabungan
      {
      get { return _targetTabungan; }
      set { _targetTabungan = value; }
      }
   }
}
