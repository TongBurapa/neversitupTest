package function

func OddNumberFinder(arr []int) int {
	elementMap := make(map[int]int)

	for _, num := range arr {
		elementMap[num] = elementMap[num] + 1
	}

	for num, count := range elementMap {
		if count%2 != 0 {
			return num
		}
	}
	return -1
}
