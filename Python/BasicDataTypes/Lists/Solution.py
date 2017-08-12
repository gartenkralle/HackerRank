
if __name__ == '__main__':

    N = int(input())

    Numbers = list()

    for _ in range(N):
        line = str(input())
        CommandList = line.split()
        Command = str(CommandList[0])

        if(Command == "insert"):
            Index = int(CommandList[1])
            Element = int(CommandList[2])
            Numbers.insert(Index, Element)
        elif(Command == "print"):
            print(Numbers)
        elif(Command == "remove"):
            Element = int(CommandList[1])
            Numbers.remove(Element)
        elif(Command == "append"):
            Element = int(CommandList[1])
            Numbers.append(Element)
        elif(Command == "sort"):
            Numbers.sort()
        elif(Command == "pop"):
            Numbers.pop()
        elif(Command == "reverse"):
            Numbers.reverse()
