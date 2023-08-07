function canJump(arr: number[], index: number): boolean {
  if (arr[index] === arr[arr.length - 1]) {
    return true;
  }
  if (index >= arr.length) {
    return false;
  }
  var result = makeJump(arr, index);
  if (result === index) {
    return false;
  }
  return canJump(arr, result);
}
const makeJump = (arr: number[], index: number): number => {
  var jumpsToIndex = index + arr[index];
  return jumpsToIndex;
};

console.log(canJump([2, 3, 1, 1, 4], 0));
console.log(canJump([3, 2, 1, 0, 4], 0));
console.log(canJump([2, 3, 1, 1, 1, 4], 0));
