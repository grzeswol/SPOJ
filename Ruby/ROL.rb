while gets
	a, b = $_.split.map(&:to_i)
	puts gets.split(' ').rotate(b).join(' ')
end
