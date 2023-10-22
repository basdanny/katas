package main

import "fmt"

func fibonacci() func() int {
	left := 0
	right := 1
	return func() int {
		oldLeft := left
		left = right
		right = oldLeft + right
		return oldLeft
	}
}

func Fib() {
	f := fibonacci()
	for i := 0; i < 10; i++ {
		fmt.Printf("%v ", f())
	}
}
