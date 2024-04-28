package unit_test

import (
	odd "oddNumberTest/function"
	"testing"
)

func TestAllOddNumber(t *testing.T) {
	tests := []struct {
		name  string
		input []int
		want  int
	}{
		{name: "7", input: []int{7}, want: 7},
		{name: "0", input: []int{0}, want: 0},
		{name: "1,1,2", input: []int{1, 1, 2}, want: 2},
		{name: "0,1,0,1,0", input: []int{0, 1, 0, 1, 0}, want: 0},
		{name: "1,2,2,3,3,3,4,3,3,3,2,2,1", input: []int{1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1}, want: 4},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			got := odd.OddNumberFinder(tc.input)

			if got != tc.want {
				t.Errorf("Expected %d , got %d ", tc.want, got)
			}
		})
	}
}
