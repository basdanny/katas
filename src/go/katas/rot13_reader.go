package main

import (
	"errors"
	"io"
	"os"
	"strings"
)

type rot13Reader struct {
	r io.Reader
}

func (r *rot13Reader) Read(p []byte) (int, error) {
	if len(p) <= 0 {
		return 0, errors.New("bad input bytes")
	}

	n, err := r.r.Read(p)
	if err != nil {
		return n, err
	}

	for i := 0; i < n; i++ {
		if p[i] >= 'a' && p[i] <= 'z' {
			p[i] = 'a' + ((p[i] - 'a' + 13) % 26)
		} else if p[i] >= 'A' && p[i] <= 'Z' {
			p[i] = 'A' + ((p[i] - 'A' + 13) % 26)
		}
	}

	return n, nil
}

func Rot13Reader() {
	s := strings.NewReader("Lbh penpxrq gur pbqr!")
	r := rot13Reader{s}
	io.Copy(os.Stdout, &r)
}
