package permutate_test

import (
	perm "goPermutate/permutate"
	"testing"
)

func TestAllPermutations(t *testing.T) {
	tests := []struct {
		name  string
		input string
		want  []string
	}{
		{name: "Empty string", input: "", want: []string{""}},
		{name: "Single character", input: "a", want: []string{"a"}},
		{name: "Two Character", input: "ab", want: []string{"ab", "ba"}},
		{name: "No duplicates", input: "abc", want: []string{"abc", "acb", "bac", "bca", "cab", "cba"}},
		{name: "Duplicates", input: "aabb", want: []string{"aabb", "abab", "abba", "baab", "baba", "bbaa"}},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			got := perm.AllPermutations(tc.input)
			if len(got) != len(tc.want) {
				t.Errorf("Expected %d permutations, got %d", len(tc.want), len(got))
			}

			for _, p := range got {
				found := false
				for _, w := range tc.want {
					if p == w {
						found = true
						break
					}
				}
				if !found {
					t.Errorf("Permutation '%s' not found in expected results", p)
				}
			}
		})
	}
}
