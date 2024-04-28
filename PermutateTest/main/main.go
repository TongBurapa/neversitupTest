package main

import (
	"fmt"
	perm "goPermutate/permutate"
)

func main() {
	str := "abc"
	permutations := perm.AllPermutations(str)
	fmt.Println("All Permutations of", str, "are:")
	for _, perm := range permutations {
		fmt.Println(perm)
	}
}
