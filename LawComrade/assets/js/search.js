	const searchBox =document.querySelector(".search-box input[type='text']");
	const searchForm = document.querySelector('#search-form');
    const suggestionsList= document.querySelector(".search-box ul");
    const suggestions = ["Section 1", "Section 2", "Section 3", "Section 4 ", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10 ", "Section 11 ", "Section 12 ", "Section 13 ", "Section 14 ", "Section 15 ", "Section 16 ", "Section 17 ", "Section 18 ", "Section 19 ", "Section 20 ", "Section 21 ", "Section 22 ", "Section 23 ", "Section 24 ", "Section 25 ", "Section 26 ", "Section 27 ", "Section 28 ", "Section 29 ", "Section 29A", "Section 30", "Section 31", "Section 32", "Section 33", "Section 34", "Section 35", "Section 36", "Section 37", "Section 38", "Section 39", "Section 40 ", "Section 41 ", "Section 42 ", "Section 43 ", "Section 44 ", "Section 45 ", "Section 46 ", "Section 47 ", "Section 48 ", "Section 49 ", "Section 50 ", "Section 51 ", "Section 52 ", "Section 52A", "Section 53 ", "Section 53A", "Section 54 ", "Section 55 ", "Section 55A", "Section 56 ", "Section 57 ", "Section 58 ", "Section 59 ", "Section 60", "Section 61", "Section 62", "Section 63", "Section 64", "Section 65", "Section 66", "Section 67", "Section 68", "Section 69", "Section 70", "Section 71", "Section 72", "Section 73", "Section 74", "Section 75", "Section 76", "Section 77", "Section 78", "Section 79", "Section 80", "Section 81", "Section 82", "Section 83", "Section 84", "Section 85", "Section 86", "Section 87", "Section 88", "Section 89", "Section 90", "Section 91", "Section 92", "Section 93", "Section 94", "Section 95", "Section 96", "Section 97", "Section 98", "Section 99", "Section 100",
			"Section 101", "Section 102", "Section 103", "Section 104", "Section 105", "Section 106", "Section 107", "Section 108", "Section 108A", "Section 109", "Section 110", "Section 111", "Section 112 ", "Section 113", "Section 114", "Section 115", "Section 116", "Section 117", "Section 118", "Section 119", "Section 120", "Section 120B", "Section 120B", "Section 121", "Section 121A", "Section 122 ", "Section 123", "Section 124", "Section 124A", "Section 125", "Section 126", "Section 127", "Section 128", "Section 129", "Section 130", "Section 131", "Section 132 ", "Section 133", "Section 134", "Section 135", "Section 136", "Section 137", "Section 138", "Section 138A", "Section 139", "Section 140", "Section 141", "Section 142 ", "Section 143", "Section 144", "Section 145", "Section 146", "Section 147", "Section 148", "Section 149", "Section 150", "Section 151", "Section 152 ", "Section 153", "Section 153A", "Section 153AA", "Section 153B", "Section 154", "Section 155", "Section 156", "Section 157", "Section 158", "Section 159", "Section 160", "Section 161", "Section 162 ", "Section 163", "Section 164", "Section 165", "Section 165A", "Section 166", "Section 166A", "Section 166B", "Section 167", "Section 168", "Section 169", "Section 170", "Section 171", "Section 171A", "Section 171B", "Section 171C", "Section 171D", "Section 171E", "Section 171F", "Section 171G", "Section 171H", "Section 171I", "Section 172 ", "Section 173", "Section 174", "Section 174A", "Section 175", "Section 176", "Section 177", "Section 178", "Section 179", "Section 180", "Section 181", "Section 182 ", "Section 183", "Section 184", "Section 185", "Section 186", "Section 187", "Section 188", "Section 189", "Section 190", "Section 191", "Section 192 ", "Section 193", "Section 194", "Section 195", "Section 195A", "Section 196", "Section 197", "Section 198", "Section 199", "Section 200",
			"Section 201", "Section 202", "Section 203", "Section 204", "Section 205", "Section 206", "Section 207", "Section 208", "Section 209", "Section 210", "Section 211", "Section 212", "Section 213", "Section 214", "Section 215", "Section 216", "Section 216A", "Section 216B", "Section 217", "Section 218", "Section 219", "Section 220", "Section 221", "Section 222", "Section 223", "Section 224", "Section 225", "Section 225A", "Section 225B ", "Section 226", "Section 227", "Section 228", "Section 228A", "Section 229", "Section 229A", "Section 230", "Section 231", "Section 232", "Section 233", "Section 234", "Section 235", "Section 236", "Section 237", "Section 238", "Section 239", "Section 240", "Section 241", "Section 242", "Section 243", "Section 244", "Section 245", "Section 246", "Section 247", "Section 248", "Section 249", "Section 250", "Section 251", "Section 252", "Section 253", "Section 254", "Section 255", "Section 256", "Section 257", "Section 258", "Section 259", "Section 260", "Section 261", "Section 262", "Section 263", "Section 263A", "Section 264", "Section 265", "Section 266", "Section 267", "Section 268", "Section 269", "Section 270", "Section 271", "Section 272", "Section 273", "Section 274", "Section 275", "Section 276", "Section 277", "Section 278", "Section 279", "Section 280", "Section 281", "Section 282", "Section 283", "Section 284", "Section 285", "Section 286", "Section 287", "Section 288", "Section 289", "Section 290", "Section 291", "Section 292", "Section 293", "Section 294", "Section 294A", "Section 295", "Section 295A", "Section 296", "Section 297", "Section 298", "Section 299", "Section 300",
			"Section 301", "Section 302", "Section 303", "Section 304", "Section 304A", "Section 304B", "Section 305", "Section 306", "Section 307", "Section 308", "Section 309", "Section 310", "Section 311", "Section 312", "Section 313", "Section 314", "Section 315", "Section 316", "Section 317", "Section 318", "Section 319", "Section 320", "Section 321", "Section 322", "Section 323", "Section 324", "Section 325", "Section 326", "Section 326A", "Section 326B", "Section 327", "Section 328", "Section 329", "Section 330", "Section 331", "Section 332", "Section 333", "Section 334", "Section 335", "Section 336", "Section 337", "Section 338", "Section 339", "Section 340", "Section 341", "Section 342", "Section 343", "Section 344", "Section 345", "Section 346", "Section 347", "Section 348", "Section 349", "Section 350", "Section 351", "Section 352", "Section 353", "Section 354", "Section 354A", "Section 354B", "Section 354C", "Section 354D", "Section 355", "Section 356", "Section 357", "Section 358", "Section 359", "Section 360", "Section 361", "Section 362", "Section 363", "Section 363A ", "Section 364", "Section 364A", "Section 365", "Section 366", "Section 366A", "Section 366B", "Section 367", "Section 368", "Section 369", "Section 370", "Section 370A", "Section 371", "Section 372", "Section 373", "Section 374", "Section 375", "Section 376", "Section 376A", "Section 376AB", "Section 376B", "Section 376C", "Section 376D", "Section 376DA", "Section 376DB", "Section 376E", "Section 377", "Section 378", "Section 379", "Section 380", "Section 381", "Section 382", "Section 383", "Section 384", "Section 385", "Section 386", "Section 387", "Section 388", "Section 389", "Section 390", "Section 391", "Section 392", "Section 393", "Section 394", "Section 395", "Section 396", "Section 397", "Section 398", "Section 399", "Section 400",
			"Section 401 ", "Section 402 ", "Section 403", "Section 404", "Section 405", "Section 406", "Section 407", "Section 408", "Section 409", "Section 410", "Section 411 ", "Section 412 ", "Section 413", "Section 414", "Section 415", "Section 416", "Section 417", "Section 418", "Section 419", "Section 420", "Section 421 ", "Section 422 ", "Section 423", "Section 424", "Section 425", "Section 426", "Section 427", "Section 428", "Section 429", "Section 430", "Section 431 ", "Section 432 ", "Section 433", "Section 434", "Section 435", "Section 436", "Section 437", "Section 438", "Section 439", "Section 440", "Section 441 ", "Section 442 ", "Section 443", "Section 444", "Section 445", "Section 446", "Section 447", "Section 448", "Section 449", "Section 450", "Section 451 ", "Section 452 ", "Section 453", "Section 454", "Section 455", "Section 456", "Section 457", "Section 458", "Section 459", "Section 460", "Section 461 ", "Section 462 ", "Section 463", "Section 464", "Section 465", "Section 466", "Section 467", "Section 468", "Section 469", "Section 470", "Section 471 ", "Section 472 ", "Section 473", "Section 474", "Section 475", "Section 476", "Section 477", "Section 477A", "Section 478", "Section 479", "Section 480", "Section 481 ", "Section 482 ", "Section 483", "Section 484", "Section 485", "Section 486", "Section 487", "Section 488", "Section 489", "Section 489A", "Section 489B", "Section 489C", "Section 489D", "Section 489E", "Section 490", "Section 491 ", "Section 492 ", "Section 493", "Section 494", "Section 495", "Section 496", "Section 497", "Section 498", "Section 498A", "Section 499", "Section 500",
			"Section 501 ", "Section 502 ", "Section 503", "Section 504", "Section 505", "Section 506", "Section 507", "Section 508", "Section 509 ", "Section 510", "Section 511"];

    searchBox.addEventListener("keyup", () => 
    {
        const searchTerm =searchBox.value.toLowerCase();
        const filteredSuggestions =suggestions. filter((suggestion) => 
        {
            return suggestion.toLowerCase().startsWith(searchTerm);
        });

        displaySuggestions(filteredSuggestions);
    });

    const displaySuggestions =(suggestions) => 
    {
        const html =suggestions.map((suggestion) => 
        {
            return `<li>${suggestion}</li>`;
        }).join("");

        suggestionsList.innerHTML= html;
        if (searchBox.value!=="") 
        {
            suggestionsList.style.display = "block";
        }
        else 
        {
            suggestionsList.style.display = "none";
        }
    };
    suggestionsList.addEventListener("click", (event) => 
    {
        if(event.target.tagName ==="LI")
        {
            searchBox.value =event.target.textContent;
            suggestionsList.style.display = "none";
        }
    });

	searchForm.addEventListener('submit', event => 
	{
		event.preventDefault();
		const searchQuery = searchBox.value;
		const articleUrl = getArticleUrl(searchQuery);
		if (articleUrl) 
		{
		window.location.href = articleUrl;
		} 
		else 
		{
		fetch('/api/search?q=' + searchQuery)
			.then(response => response.json())
			.then(data => displaySearchResults(data));
		}
  	});

	  function getArticleUrl(searchQuery) 
	  {
		switch (searchQuery) 
		{
			case 'Section 1':
				return '#section1';
			case 'Section 2':
				return '#section2';
			case 'Section 3':
				return '#section3';
			case 'Section 4':
				return '#section4';
			case 'Section 5':
				return '#section5';
			case 'Section 6':
				return '#section6';
			default:
				return null;
   		}
  	}
      function hideAndShow() 
      {
          var searchValue = document.getElementById("search-input").value;
          console.log(searchValue);
          for (var i = 1; i <= 6; i++) 
          { 
              var section = document.getElementById("section" + i);
              if (section.style.display === "none") 
              { 
                  section.style.display = "block";
              } 
              else 
              {
                  section.style.display = "none";
              }
          }
      }