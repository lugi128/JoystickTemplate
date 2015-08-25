using System;
using System.Threading;

namespace JoystickTemplate
{
	public class Joysick
	{
		/// <summary>
		/// Random simulate joystick position
		/// </summary>
		private static Random r = new Random();
		/// <summary>
		/// Random simulate joystick position
		/// </summary>
		private static Random y = new Random();
		/// <summary>
		/// If any reload time is set the program use the default
		/// </summary>
		private static int defaultReloadTime = 300;
		/// <summary>
		/// The default is set here
		/// </summary>
		private static int _reloadTime = defaultReloadTime;
		/// <summary>
		/// Gets the axe x.
		/// </summary>
		/// <value>The axe x. In real condition this method get the X position</value>
		private static double AxeX {
			get { 
				//while (true)
				return r.Next (1000); 
			}
		}
		/// <summary>
		/// Gets the axe y.
		/// </summary>
		/// <value>The axe y. In real condition this method get the Y position</value>
		private static double AxeY{
			get {
				//while (true)
				return y.Next (1000); 
			}
		}
		/// <summary>
		/// Sets the reload time.
		/// </summary>
		/// <value>The reload time.</value>
		public static int reloadTime
		{
			set { _reloadTime = value; }
		}
		public static void print ()
		{
			double _AxeX;
			double _AxeY;
			while (true) {
				// Actualisation des positions 
				_AxeX = AxeX;
				_AxeY = AxeY;
				// Sortie ("print")
				Console.WriteLine ("Axe X : " + _AxeX.ToString ());
				Console.WriteLine ("Axe Y : " + _AxeY.ToString ());
				Thread.Sleep (_reloadTime);
				Console.Clear ();
			}
		}
	}
}

