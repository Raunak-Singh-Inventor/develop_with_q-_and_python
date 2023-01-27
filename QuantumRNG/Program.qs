namespace QuantumRNG {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation GenerateRandomBitString(): Int {
        let max = 128;
        Message($"Choosing random number between 0 and {max}: ");
        let len = getBitStringLength(max);
        mutable output = 0;
        mutable res = new Result[len+1];
        repeat {
            for i in 0 .. len {
                let bit = GenerateRandomBit();
                set res w/= i <- bit;
            }
            set output = ResultArrayAsInt(res);
        } until (output<=max);
        return output;
    }

    operation GenerateRandomBit(): Result {
        use q = Qubit(); // allocate a qubit
        H(q); // put qubit in superposition
        return M(q); // measure the qubit   
    }  

    operation getBitStringLength(max : Int): Int {
        mutable len=0;
        repeat {
            set len = len + 1;
        } until 2^len > max;
        return len;
    }
}
