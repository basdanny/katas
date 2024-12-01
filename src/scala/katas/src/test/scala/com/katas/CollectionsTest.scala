package main.scala.com.katas

import org.scalatest.funspec._
import com.katas.Collections._

class CollectionsTest extends AnyFunSpec {

  val collectionDiffTests = Seq(
    (Seq(1, 2), Seq(1), Seq(2)),
    (Seq(1, 2, 2), Seq(1), Seq(2, 2)),
    (Seq(1, 2, 2), Seq(2), Seq(1)),
    (Seq(1, 2, 2), Seq(), Seq(1, 2, 2)),
    (Seq(), Seq(1, 2), Seq())
  )

  describe("Collection Difference tests:") {
    collectionDiffTests.foreach { case (a, b, expected) =>
      it(s" Difference between $a and $b should be $expected") {
        assert(arrayDiff(a, b) == expected)
      }
    }
  }

}
