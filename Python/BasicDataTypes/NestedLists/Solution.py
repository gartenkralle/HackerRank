def getStudentKey(student):
    return student[1]

if __name__ == '__main__':
    studentList = list()
    result = list()

    for _ in range(int(input())):
        name = input()
        score = float(input())
        student = [name, score]
        studentList.append(student)

    studentList.sort(key = getStudentKey)
    lowestScore = studentList[0][1]  
    
    while(lowestScore == studentList[0][1]):
        studentList.remove(studentList[0])

    lowestScore = studentList[0][1]

    while((studentList) and (lowestScore == studentList[0][1])):
        result.append(studentList[0][0])
        studentList.remove(studentList[0])

    result.sort()

    for item in result:
        print(item)
