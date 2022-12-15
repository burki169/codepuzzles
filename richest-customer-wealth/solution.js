/**
 * You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in 
 * the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has. A customer's wealth is the amount of money they 
 * have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
 * 
 * Input: accounts = [[1,5],[7,3],[3,5]]
 * Output: 10
 * Explanation: 
 * 1st customer has wealth = 6
 * 2nd customer has wealth = 10 
 * 3rd customer has wealth = 8
 * The 2nd customer is the richest with a wealth of 10.
 */

/**
 * @param {number[][]} accounts
 * @return {number}
 */
const maximumWealth = (accounts) => {    
    const totalWealth = accounts.flatMap( accountWealthArray =>{
        const totalWealth = accountWealthArray.reduce( (prevValue, currentValue) =>{
            return prevValue+currentValue;
        }, 0);
        return totalWealth;
    }, 0);
    return Math.max(...totalWealth);
    // let maxWealth = 0;    
    // for(let i=0; i<accounts.length; i++){
    //     const customerWealth = accounts[i].reduce( (prevValue, currentValue) =>{
    //         return prevValue+currentValue;
    //     }, 0);
    //     if(customerWealth > maxWealth){
    //         maxWealth = customerWealth
    //     }
    // }
    // return maxWealth;
};

const accounts = [[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5],[1,5],[7,3],[3,5]];
console.time();
console.log(maximumWealth(accounts));
console.timeEnd();