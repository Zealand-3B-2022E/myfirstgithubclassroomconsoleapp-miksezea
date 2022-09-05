using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
		// Instances
		private string _navn;
		private int _alder;
		private int _skostørrelse;

		// Properties
		public string Navn
		{
			get { return _navn; }
			set { _navn = value; }
		}
		public int Alder
		{
			get { return _alder; }
			set { _alder = value; }
		}
		public int Skostørrelse
		{
			get { return _skostørrelse; }
			set { _skostørrelse = value; }
		}

		// Constructors

		public Demo(string navn, int alder, int skostørrelse)
		{
			_navn = navn;
			_alder = alder;
			_skostørrelse = skostørrelse;
		}
	}
}
