// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("TudVXocmP0IDxYUCOIWvXxugfZp9PmBXmbUnWAxygjwznnkvS0goauCrpKaZ6zIh2E4KlWXC+2bnSMJVGfu70mKI2Ss08zFY/kmvuf1eUAxYBogA50FY2p23tqCNGaJkWMPn3rE4Wii7bWuUe2B7DPNwF2hFkRhpap07bVQN18U9O+0fvb3zTf1AfrBgWg/fEKYz/0ImgOPbjQ+r3tcxEqUmKCcXpSYtJaUmJie/8AHc5zKcF6UmBRcqIS4NoW+h0ComJiYiJyTKIvjs6RUmZaw+Z6n5FL5lIdQYm2i7tOlTYMwQM78aAQyAAgUT94FNTAx2wSivCB7JIbfJHAGtlCUjh+zTeNxXaeiNOjXoF6umJ4+hzYD0JOyL5nLcTEKo4iUkJicm");
        private static int[] order = new int[] { 8,2,9,7,12,11,6,11,9,9,10,12,12,13,14 };
        private static int key = 39;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
