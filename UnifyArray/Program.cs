
using System.Linq;

foreach (var num in (ReturnIntersection(new int[] {1, 2, 2}, new int[] {1}))){
    System.Console.WriteLine(num);
}
int[] ReturnIntersection(int[] arr1, int[] arr2){
    return arr1.Distinct();
}