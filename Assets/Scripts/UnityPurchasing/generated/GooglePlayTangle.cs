// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("+VDi6TCRiPW0cjK1jzIY6KwXyi2gEpGyoJ2WmboW2BZnnZGRkZWQk2TPa+DeXzqNgl+gHBGQOBZ6N0OT77E/t1D2720qAAEXOq4V0+90UGnKidfgLgKQ77vFNYuEKc6Y/P+f3fu7wXafGL+pfpYAfqu2GiOSlDBbfZVPW16ikdIbidAeTqMJ0pZjrywGj+2fDNrcI8zXzLtEx6Df8iav3t8MA17k13unhAittrs3tbKkQDb6EpGfkKASkZqSEpGRkAhHtmtQhStXHBMRLlyFlm/5vSLSdUzRUP914t0qjNrjumByioxaqAoKRPpK98kHrkwMZdU/bpyDRIbvSf4YDkrp57vX7bhopxGESPWRN1RsOrgcaWCGpVs8UcVr+/UfVZKTkZCR");
        private static int[] order = new int[] { 8,8,13,12,13,12,10,11,13,13,13,13,13,13,14 };
        private static int key = 144;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
