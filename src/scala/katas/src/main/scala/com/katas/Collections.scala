package com.katas

object Collections {

    // Implement a difference function, which subtracts one list from another and returns the result.
    // It should remove all values from list a, which are present in list b keeping their order.
    def arrayDiff(a: Seq[Int], b: Seq[Int]): Seq[Int] = a.filterNot(b.toSet.contains)

}
