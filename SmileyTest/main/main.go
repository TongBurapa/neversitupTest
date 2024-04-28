package main

import (
	"fmt"
	smile "smileyTestGo/function"
)

func main() {
	input := []string{":D", ":-(", ":-)", ";~)"}
	output := smile.SmileyCheck(input)
	fmt.Println(output)
}
