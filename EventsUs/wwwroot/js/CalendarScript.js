$(document).ready(function () {
    var lastClickedElement = null;
    var currMonth, currYear;
    var initTemplateCalendar = function (id, month, year) {
        var $cal = $(id);
        $cal = $($cal[0]);
        var arrayDayShort = ['Sun', 'Mon', 'Tues', 'Wed', 'Thurs', 'Fri', 'Sat'];
        var arrayDayLong = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
        var monthNames = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
        var holidays = [{
            date: "Sep 19, 2016",
            holiday: "Labour Day"
        }];
        var imageCollection = ["http://newpartners.uatisready.com/images/listings/CBCFlightofWhite1920x800_2628606653001467481.jpg?res=200", "http://newpartners.uatisready.com/images/listings/hist1_7854081356274510997.jpg?res=200", "http://newpartners.uatisready.com/images/listings/sens_2391958875910645713.jpg?res=200", "http://newpartners.uatisready.com/images/listings/1920800Garden_4119985474150635077.jpg?res=200", "http://newpartners.uatisready.com/images/listings/f044fa55-d527-4807-abbe-2d315a26c150.jpg?res=200"];

        console.log('Creating Calendar...');
        console.info('Month: ' + month);
        console.info('Year: ' + year);
        currMonth = month;
        currYear = year;
        month = month - 1;
        var d = new Date(year, month);


        //Table Main Title
        var table = ['<div class="calHeader"><div class="prevMonth">Previous&nbsp;Month</div><div class="monthSelector">' + monthNames[d.getMonth()] + ' ' + d.getFullYear() + '<div class="monthPicker"></div></div><div class="nextMonth">Next&nbsp;Month</div></div>'];

        //Table Header
        table.push('<table><tr class="header">');
        for (var i = 0; i < 7; i++) {
            table.push('<th>' + arrayDayShort[i] + '</th>');
        }
        table.push('</tr><tr>');

        //Table Dates
        for (var i = 0; i < d.getDay(); i++) {
            table.push('<td><div class="dayWrapper"><div class="dayContainer"></div><div class="contentContainer"></div></div></td>');
        }
        var day = 1;
        while (d.getMonth() == month) {
            m = month + 1;
            table.push('<td><div id="day' + d.getDate() + '" class="dayWrapper">'
                + '<div class="dayContainer event">'
                + '<div class="dayTitle"></div>'
                + '<div class="dayBox">' + padLeftZeroes(d.getDate(), 2) + '</div>'
                + '</div>'
                + '<script> document.getElementById("contentContainer:' + day + '/' + m + '/' + d.getFullYear() + '").addEventListener("load",allDetails(' + day+','+m+','+ d.getFullYear()+'))</script >'
                + '<div id="contentContainer:' + day + "/" + m+ "/" + d.getFullYear() + '" class="contentContainer">'
                //+ '<div class="contentItem"><p onload="javaScript:allDetails();"></p></div>'
                //+ '<div class="contentItem">Data</div>'
                //+ '<div class="contentItem">Data</div>'
                //+ '<div class="contentMore"><button onclick="javaScript:onEvent(' + d.getDay() + ',' + d.getMonth() + ',' + d.getYear() +');">More...</button></div>'
                + '</div>'
                + '</div></td>');
            
            if (d.getDay() % 7 == 6) {
                table.push('</tr><tr>');
            }
            d.setDate(d.getDate() + 1);
            day++;
        }

        //Table End Dates
        for (var i = d.getDay(); i < 7; i++) {
            table.push('<td><div class="dayWrapper"><div class="dayContainer"></div><div class="contentContainer"></div></div></td>');
        }
        table.push('</tr></table>');
        $cal.html(table.join('\n'));

        //Set holidays
        for (var i = 0; i < holidays.length; i++) {
            var hd = new Date(Date.parse(holidays[i].date));
            if (hd.getMonth() === currMonth - 1) {
                id = '#day' + hd.getDate();
                setDayStyle(id, 'holiday');
                $(id + ' .dayTitle').html(holidays[i].holiday);
            }
        }

        //Select event
        $cal.find('.dayWrapper').click(function () {
            //reset last selected
            removeDayStyle(lastClickedElement, 'selected');
            lastClickedElement = this;
            if ($(this).find('.dayContainer').hasClass('event')) {
                setDayStyle(this, 'selected');
            }
        });

        //Randomly put images on i=number of images
        for (var i = 0; i < 9; i++) {
            var image = imageCollection[getRandomIntInclusive(0, 4)];
            var dayTag = '#day' + getRandomIntInclusive(1, 31);
            $(dayTag + ' .dayContainer').css('background', 'url("' + image + '")');
        }

        //Month selector click
        $('.monthSelector').click(function () {
            var $mPicker = $('.monthPicker');
            if ($mPicker.css('display') === "none") {
                $mPicker.slideDown();
            } else {
                $mPicker.slideUp();
            }
        });

        //Populate monthSelector with next 11 months
        var monthDivs = [];
        var iterMonth = currMonth + 1;
        var iterYear = currYear;
        for (var i = 0; i < 11; i++) {
            var monthName = monthNames[iterMonth - 1];
            var yearName = iterYear;
            monthDivs.push('<div class="monthPickerItem" data-month="' + iterMonth + '" data-year="' + yearName + '">' + monthName + ' ' + yearName + '</div>');
            if (iterMonth === 12) { iterMonth = 1; iterYear++; }
            else { iterMonth++; }
        }
        $('.monthPicker').append(monthDivs.join('\n'));

        $('.monthPickerItem').click(function (e) {
             console.log(e);
            var targProps = e.target.attributes;
            var month = parseInt(targProps["data-month"].value);
            var year = parseInt(targProps["data-year"].value);
            if (month && year) {
                initTemplateCalendar('#calendar', month, year);
            }
        });

        $('.nextMonth, .prevMonth').click(function (e) {
            if (e.target.className === "prevMonth") {
                 console.log('prev');
                //month should be 0 based but due to correction in init func, we use 1 base
                if (currMonth === 1) {
                    currMonth = 12;
                    currYear--;
                } else {
                    currMonth--;
                }
            } else if (e.target.className === "nextMonth") {
                 console.log('next');
                if (currMonth === 12) {
                    currMonth = 1;
                    currYear++;
                } else {
                    currMonth++;
                }
            }
             console.log(currMonth);
             console.log(currYear);
            initTemplateCalendar('#calendar', currMonth, currYear);
        });

        function setDayStyle(id, cssClass) {
            $(id).find('.dayContainer, .contentContainer, .dayTitle, .dayBox, .contentItem, .contentMore').addClass(cssClass);
        }

        function removeDayStyle(id, cssClass) {
            $(id).find('.dayContainer, .contentContainer, .dayTitle, .dayBox, .contentItem, .contentMore').removeClass(cssClass);
        }

        function padLeftZeroes(obj, padLength) {
            if (!obj.toString().length || obj.length > padLength) return obj;
            var str = obj.toString();
            var newStr = "";
            for (var i = 0; i < padLength; i++) {
                if (i > padLength - str.length - 1) {
                    newStr = newStr + str;
                    return newStr;
                }
                newStr = newStr + "0";
            }
        }

        function getRandomIntInclusive(min, max) {
            return Math.floor(Math.random() * (max - min + 1)) + min;
        }
    }

    var today = new Date(); // init Calendar 
    var initMonth = today.getMonth() +1;
    var initYear = today.getFullYear();
    initTemplateCalendar('#calendar', initMonth, initYear);

});