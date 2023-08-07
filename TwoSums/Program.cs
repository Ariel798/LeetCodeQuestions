var arr = new int[]{4,3,2,1,5,3};
var res = ReturnSumIndices(arr,7);
foreach(var num in res){
    System.Console.WriteLine(num);
}
int[] ReturnSumIndices(int[] arr, int target){
    for(int i =0 ; i<arr.Length-1; i++){
        for(int j = i +1; j<arr.Length-1; j++){
            if(arr[i] + arr[j] == target){
                return new int[]{arr[i], arr[j]};
            }
        }
    }
    return new int[0];
}