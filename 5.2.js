console.log("10 / 5.6 + 13.3 * 5 = "+mathcalc("10 / 5.6 + 13.3 * 5 = "));

function mathcalc(str_tmp) {
    var res = 0,match_arr=[];
    var reg_match = /[\+,\-,\*,\/,\=]{1}|\-?\d+(\.\d+)?/ig;
    match_arr = str_tmp.match(reg_match);
    
    if (Number(match_arr[0]) + "" != "NaN") {
        res += Number(match_arr[0]);
    }

    for (var i = 1; i < match_arr.length; i++) {
        switch (match_arr[i]) {
            case "+": res += Number(match_arr[i + 1]); break;
            case "-": res -= Number(match_arr[i + 1]); break;
            case "*": res *= Number(match_arr[i + 1]); break;
            case "/": res /= Number(match_arr[i + 1]); break;
            case "=": break;
            default: continue;
        }
    }
    return res.toFixed(2);
    
}
