using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.PackageTask
{
    public class Packages
    {
        public List<Package> packages = new List<Package>();


        /* packages = [ 3   , 8  , 4 , 1 ]
 * 
 * for i=0
 *     findSmallestItem(packages)
 *     {
 *        for i = 0
 *        smallest = 3
 *             if (3  < 3)  => false
              {
                  smallest = packages[i].weight;
                  smallestIndex = i;
              }

 *        for i = 1
 *        smallest = 3
 *             if (8  < 3)  => false
              {
                  smallest = packages[i].weight;
                  smallestIndex = i;
              }

 *        for i = 2
 *        smallest = 3
 *             if (4  < 3) => false
              {
                  smallest = packages[i].weight;
                  smallestIndex = i;
              }
 *        for i = 3
 *        smallest = 3
 *             if (1  < 3)  => true
              {
                  smallest =  1;
                  smallestIndex = 3;
              }
 *        returne =>  smallestIndex = 3
 *     }
 *     
 *     
 *     
 * 
 * امررللها البكجز لست
 * GetSortPackageList {
 *
 * while  packages.size > 0 {
 * 
 * روح الكالي اصغر عنصر وضيفليا بلستة جديدة
 * 
 *   sortList [1]
 * }
 * 
 * }
 * 
 */
        public List<Package> GetSortPackageList(List<Package> packages)
        {
            List<Package> sortList = new List<Package>();

            //  [ 3   , 8  , 4 , 1 ]
            int indextSmallestItem = 0;
            while (packages.Count > 0)
            {
                // حيلكة موقع اصغر عنصر 
                indextSmallestItem = findSmallestItem(packages);
                //[1 ,]
                //هنا حيضيف اصغر عنصر حسب موقع الي لكيته
                sortList.Add(packages[indextSmallestItem]);

                //هنا احذفة من اللستة الاصلية حتى لمن ارجع اجيب اصغر عنصر ميتكرر ويصير اللوجك غلط
                packages.Remove(packages[indextSmallestItem]);
            }

            return sortList;
        }


        // ارجع اندكس لاصغر عنصر جايني من لست البكج
        int findSmallestItem(List<Package> packages)
        {
            //3
            var smallest = packages[0].weight;
            int smallestIndex = 0;

            //[3, 8, 4, 1]
            // هنا نسوي لوب ع لست البكج و نسوي سورت الها لاصغر عنصر
            for (int i = 0; i < packages.Count; i++)
            {
                //شرط  ايجاد اصغر عنصر والرجاعه
                if (packages[i].weight < smallest)
                {
                    smallest = packages[i].weight;
                    //موقع اصغر عنصر
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
    }

}
