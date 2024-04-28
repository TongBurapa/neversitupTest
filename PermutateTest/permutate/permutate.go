package permutate

func permute(s string, prefix string, used map[rune]bool, permutations *[]string) {
	if len(s) == 0 {
		*permutations = append(*permutations, prefix)
		return
	}

	for i, char := range s {
		if used[char] {
			if i > 0 && rune(prefix[len(prefix)-1]) == char {
				continue
			}
		}
		used[char] = true
		permute(s[:i]+s[i+1:], prefix+string(char), used, permutations)
		used[char] = false
	}
}

func AllPermutations(s string) []string {
	used := make(map[rune]bool)
	permutations := []string{}
	permute(s, "", used, &permutations)
	nonDuplicate := removeDuplicateStr(permutations)
	return nonDuplicate
}

func removeDuplicateStr(strSlice []string) []string {
	allKeys := make(map[string]bool)
	list := []string{}
	for _, item := range strSlice {
		if _, value := allKeys[item]; !value {
			allKeys[item] = true
			list = append(list, item)
		}
	}
	return list
}
