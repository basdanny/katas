package main

import "fmt"

func Closure() {
	values := []int{1, 2, 3}

	for _, val := range values {
		// newVal := val
		go func() {
			fmt.Println(val)
		}()
	}
}
