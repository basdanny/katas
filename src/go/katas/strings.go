package main

import (
	"fmt"
	"strings"
)

type IPAddr [4]byte

func (ipAddr IPAddr) String() string {
	return strings.Trim(strings.Join(strings.Fields(fmt.Sprintf("%v", ipAddr[:])), "."), "[]")
}

func FormatIPs() {
	hosts := map[string]IPAddr{
		"loopback":  {127, 0, 0, 1},
		"googleDNS": {8, 8, 8, 8},
	}
	for name, ip := range hosts {
		fmt.Printf("%v: %v\n", name, ip)
	}
}
