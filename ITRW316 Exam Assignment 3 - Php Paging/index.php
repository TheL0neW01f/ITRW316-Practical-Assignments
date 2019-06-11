<html>
<title>EXAM ASSIGNMENT 3</title>
<p id ="Test">
    <?php

    function getSystemMemInfo()
    {
        $data = explode("\n", file_get_contents("/proc/meminfo"));
        $meminfo = array();
        foreach ($data as $line) {
            list($key, $val) = explode(":", $line);
            $meminfo[$key] = trim($val);
        }
        return $meminfo;
    }
    $mem = getSystemMemInfo();
    printf($mem["MemTotal"]);
    ?>
</p>


<form>
    Please enter the number above in the textbox that asks "How big is the memory"
    <br>
    How big is the memory: <input type ="number" id="mem">
    <br>
    Please enter space Operating System: <input type ="number" id="OS">
    <br>
    Please enter how large page frames should be: <input type ="number" id="frame_size">
    <br>
    Enter which page you are looking for: <input type ="number" id="frame_search">
</form>
<button onclick="postdata()">show size </button>
<button onclick="addframes()">Make frames </button>
<button onclick="arraySearch()">Frame Search</button>
<p id ="Test2">

</p>
<script>
    var memorysize;
    var ossize;
    var pagesize;
    var framearray = [];
    var totalframes;
    var userInput;
    function postdata() {
        //document.getElementById("Test").innerHTML = document.getElementById("mem").value;
        memorysize = document.getElementById("mem").value;
        ossize = document.getElementById("OS").value;
        pagesize = document.getElementById("frame_size").value;
        totalframes = (memorysize-ossize)/pagesize;
        document.getElementById("Test2").innerHTML = totalframes + " number of frames";
    }
    function addframes()
    {
        while(framearray.length < totalframes){
            var r = Math.floor(Math.random()*totalframes*2) + 0;
            if(framearray.indexOf(r) === -1) framearray.push(r);
        }
        var buildString="<br>";
        for(var i=0;i<framearray.length;i++)
        {
            buildString+="Frame: "+i+" has page:"+framearray[i]+"<br>";
        }
        document.getElementById("Test2").innerHTML = buildString;
    }

    function arraySearch()
    {
        userInput = document.getElementById("frame_search").value;
        var foundString = "<br>";
        var textstring = "<br>";
        for(var i = 0; i < framearray.length; i++)
        {
            if(framearray[i] == userInput)
            {
                foundString = "Page found in index " + i;
                var xyz = true;
            }

        }
            framearray[0] = userInput;
            textstring += "Frame: " + 0 + " has page:" + userInput + "<br>";
            document.getElementById("Test2").innerHTML = foundString;
    }
</script>
</html>