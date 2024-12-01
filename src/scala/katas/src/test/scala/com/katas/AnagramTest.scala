package main.scala.com.katas

import main.scala.com.katas.Anagram._

class AnagramTest extends org.scalatest.funsuite.AnyFunSuite {
  
  test("Anagram.isAnagram") {
    assert(isAnagram("cat", "tac"))
    assert(isAnagram("cat", "taco") == false)
    assert(isAnagram("annabelle", "aanabelee") == false)
  }

  test("Anagram.isAnagram2") {
    assert(isAnagram2("cat", "tac"))
    assert(isAnagram2("cat", "taco") == false)
    assert(isAnagram2("annabelle", "aanabelee") == false)
  }

}
