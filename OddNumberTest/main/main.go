package main

import (
	"fmt"
	odd "oddNumberTest/function"
)

func main() {
	input := []int{2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 1}
	output := odd.OddNumberFinder(input)
	fmt.Println(output)
}
