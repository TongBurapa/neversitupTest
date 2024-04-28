package function

import (
	"fmt"
	"regexp"
)

func SmileyCheck(input []string) int {
	output := 0
	for i, char := range input {

		if len(input[i]) > 2 {
			pattern := `^[:;]\s*(.*?[-~]\s*.*?)\s*[D)]$`
			reg, err := regexp.Compile(pattern)
			if err != nil {
				fmt.Println("Error compiling regexp:", err)
				break
			}
			match := reg.MatchString(char)
			if match == true {
				output++
			}

		} else {
			pattern := `^[:;]\s*(.*?)\s*[D)]$`
			reg, err := regexp.Compile(pattern)
			if err != nil {
				fmt.Println("Error compiling regexp:", err)
				break
			}
			match := reg.MatchString(char)
			if match == true {
				output++
			}
		}
	}
	return output
}
