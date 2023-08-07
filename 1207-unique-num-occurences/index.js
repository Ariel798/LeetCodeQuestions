let obj = {};
let arr = [1, 1, 2];
arr.every((item) => {
    console.log(item);
  if (obj[item]) {
    obj[item]++;
  } else {
    obj[item] = 1;
  }
});
Object.entries(obj).forEach(([key, value]) => {
    console.log(`${key} ${value}`);
  });
