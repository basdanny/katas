package main.scala.com.katas

object Anagram extends App {

  def isAnagram(input1: String, input2: String) = {
    if (input1.length != input2.length) {
      false
    } else {
      val orderedInput1 = input1.toCharArray.sorted
      val orderedInput2 = input2.toCharArray.sorted

      orderedInput1.mkString == orderedInput2.mkString
      orderedInput1 sameElements orderedInput2.mkString
    }
  }


  assert(isAnagram("cat", "tac"))
  assert(isAnagram("cat", "taco") == false)
  assert(isAnagram("annabelle", "aanabelee") == false)

}
