using System.Diagnostics;
using System.Text;

namespace Interview
{
    public class SearchBytesInFile
    {
        public static int IndexOf(byte[] input, byte[] searchData)
        {            
            int searchDataLength = searchData.Length;            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == searchData[0])
                {
                    for (int j = 1; j < searchDataLength; j++)
                    {
                        if (input[i + j] != searchData[j])
                            break;
                        if (j == searchDataLength - 1)
                            return i;
                    }
                }
            }

            return -1;
        }
     


        public static void Test()
        {
            string data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non lorem ac nibh bibendum finibus. Nullam imperdiet nibh ipsum, ut varius leo tincidunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lacus augue, convallis sit amet vehicula a, commodo at tellus. Vestibulum tempus consequat tincidunt. Phasellus et erat id dui lobortis consectetur id ac magna. Mauris ut neque quis magna dignissim dignissim feugiat eget nibh. Curabitur posuere augue tortor. Cras fermentum tincidunt condimentum. Morbi id leo ante.";
            byte[] dataBytes = Encoding.ASCII.GetBytes(data);

            byte[] searchData = Encoding.ASCII.GetBytes("Praesent non lorem ac nibh bibendum finibus.");
            Debug.Assert(IndexOf(dataBytes, searchData) == 57);

            searchData = Encoding.ASCII.GetBytes("Morbi id leo ante.");
            Debug.Assert(IndexOf(dataBytes, searchData) == 519);

            searchData = Encoding.ASCII.GetBytes("Praesent not there");
            Debug.Assert(IndexOf(dataBytes, searchData) < 0);

            string data2 = "aaaba";
            byte[] dataBytes2 = Encoding.ASCII.GetBytes(data2);

            byte[] searchData2 = Encoding.ASCII.GetBytes("aab");            
            Debug.Assert(IndexOf(dataBytes2, searchData2) == 1);
        }
    }
}
