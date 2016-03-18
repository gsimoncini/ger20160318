using System;

namespace mz.erp.systemframework
{
	public class SystemTime
	{
		public SystemTime()
		{
		}
	
		//[DllImport("coredll.dll")]
		private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

		//[DllImport("coredll.dll")]
		private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);


		private struct SYSTEMTIME 
		{
			public ushort wYear;
			public ushort wMonth; 
			public ushort wDayOfWeek; 
			public ushort wDay; 
			public ushort wHour; 
			public ushort wMinute; 
			public ushort wSecond; 
			public ushort wMilliseconds; 
		}

		public System.DateTime GetTimeD
		{
			get 
			{ 
				SYSTEMTIME stime = GetTime();
				return new DateTime( stime.wYear, stime.wMonth,stime.wDay,stime.wHour,stime.wMinute,stime.wSecond,stime.wMilliseconds);
			}
		}

		private static SYSTEMTIME GetTime()
		{
			// Call the native GetSystemTime method
			// with the defined structure.
			SYSTEMTIME stime = new SYSTEMTIME();
			//GetSystemTime(ref stime);
			return stime;
			// Show the current time.           
			/*MessageBox.Show("Current Time: "  + 
				stime.wHour.ToString() + ":"
				+ stime.wMinute.ToString());*/
		}
		private static void SetTime()
		{
			// Call the native GetSystemTime method
			// with the defined structure.
			SYSTEMTIME systime = new SYSTEMTIME();
			//GetSystemTime(ref systime);
    
			// Set the system clock ahead one hour.
			systime.wHour = (ushort)(systime.wHour + 1 % 24);
			//SetSystemTime(ref systime);
			/*MessageBox.Show("New time: " + systime.wHour.ToString() + ":"
				+ systime.wMinute.ToString());*/
		}

	}
}