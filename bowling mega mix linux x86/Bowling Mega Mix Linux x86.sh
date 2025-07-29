#!/bin/sh
echo -ne '\033c\033]0;Bowling Mega Mix\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/Bowling Mega Mix Linux x86.x86_64" "$@"
