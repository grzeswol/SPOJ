def LCM(numA, numB)
	return (numA * numB) / GCD(numA, numB)
end

def GCD(numA, numB)
	if numB == 0
		return numA
	else
		return GCD(numB, numA % numB)
	end
end

gets.to_i.times do
	while gets
		a,b = $_.split.map(&:to_i)
		puts LCM(a,b)
	end
	puts $_
end





