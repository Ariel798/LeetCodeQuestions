const lengthOfLastWord = (s) => {
  const wordsArr = s.split(" ");
  let filtered = wordsArr.filter((word) => word != "" || word.includes(" "));
  return filtered[filtered.length - 1].length;
};

const sentence = "   fly me   to   the moon  ";

console.log(lengthOfLastWord(sentence));
