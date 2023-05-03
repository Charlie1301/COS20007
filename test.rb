def get_average(array)

    sum = 0

    for num in array do
        
        sum += num

    end

    average = sum.to_f/array.length.to_f

    return average

end

def double_or_single(average)

    if average >= 10

        return "Double Digits"

    else

        return "Single Digits"

    end

end

def main(array)

    average = get_average(array)

    print(average)

    puts ''

    print(double_or_single(average))

end

array = [1, 2, 3, 4]

main(array)