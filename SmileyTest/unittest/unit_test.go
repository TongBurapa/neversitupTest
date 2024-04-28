package unittest

import (
	smile "smileyTestGo/function"
	"testing"
)

func TestAllPermutations(t *testing.T) {
	tests := []struct {
		name  string
		input []string
		want  int
	}{
		{name: "TestCaseResult = 1", input: []string{";]", ":[", ";*", ":$", ";-D"}, want: 1},
		{name: "TestCaseResult = 2", input: []string{":)", ";(", ";}", ":-D"}, want: 2},
		{name: "TestCaseResule = 3", input: []string{":D", ":-(", ":-)", ";~)"}, want: 3},
	}

	for _, tc := range tests {

		t.Run(tc.name, func(t *testing.T) {
			got := smile.SmileyCheck(tc.input)

			if got != tc.want {
				t.Errorf("Expected %d smilyface, got %d smilyface", tc.want, got)
			}

		})
	}
}
