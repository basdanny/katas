package main

import (
	"fmt"
)

func main() {
	fmt.Println("Start katas!")
	fmt.Println("\n*************")

	// Fibonacci
	fmt.Println("Fibonacci:")
	Fib()
	fmt.Println("\n*************")

	// Closure
	fmt.Println("\nClosure:")
	Closure()
	fmt.Println("\n*************")

	// Strings
	// fmt.Println("\nStrings:")
	// FormatIPs()
	// fmt.Scanln()
	// fmt.Println("\n*************")

	// rot13 reader
	fmt.Println("\nRot13 reader:")
	Rot13Reader()
	fmt.Println("\n*************")

	fmt.Println("ENER to exit")
}
