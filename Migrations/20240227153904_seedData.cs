using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KodtestMio.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Soffbord i svartbetsat lackerat askfaner med en hylla för smart och praktiskt förvaring.", "/images/products/11255.jpg0", "Yesterday Soffbord, L 130 cm", 2795m, 999 },
                    { 2, "Tavellist för dina tavlor och posters. Välj mellan oljad massiv ek, lackerad ljus björk, svart eller vitlackerad mdf.\r\n", "/images/products/106501.jpg", "Living Tavellist, B 120 cm", 199m, 999 },
                    { 3, "Tavellist för dina tavlor och posters. Välj mellan oljad massiv ek, lackerad ljus björk, svart eller vitlackerad mdf.", "/images/products/16240.jpg0", "Living Tavellist, B 80 cm", 149m, 999 },
                    { 4, "Vägghylla i vitlackerad mdf med två hyllplan. Enkel att montera och varje hyllplan har en maxbelastning på fem kg vardera.", "/images/products/16289.jpg", "Living Vägghylla, H 60 cm", 199m, 999 },
                    { 5, "Vägghylla i vitlackerad mdf med fyra hyllplan. Hyllan är enkel att montera och varje hyllplan har en maxbelastning på fem kg.", "/images/products/16290.jpg", "Living Vägghylla, H 100 cm", 299m, 999 },
                    { 6, "Med sin följsamma och omfamnande känsla blir Dream en självklar favorit i många år framöver. Det som skapar den mysiga känslan är en X-pocketresår i samarbete med en 5-zons pocketresår i den övre resårkärnan. Sängens övre pocketresår ger en helt individuell avlastning vilket minskar risken för tryck som gör att du vaknar och X-pocketresåren ger madrassen en extra ytmjuk känsla som bidrar till den omfamnande känslan. För en extra stabilitet i sängen har vi lagt till en kantförstärkning i övre resårkärnan. Den undre resårkärnan har en pocketresår som gör att du får ett extra djup i sängen och mycket god följsamhet. Sängen är svensktillverkad och finns i tre olika komforter, medium, fast eller extra fast. I priset ingår bäddmadrass Sense Delux och metallben.", "/images/products/c64b5527-307a-4e9b-a5be-d0805f6b99b4_0f7.jpg", "Dream Delux Ramsäng, enkelsäng med bäddmadrass Sense Delux", 10495m, 999 },
                    { 7, "Med sin följsamma och omfamnande känsla blir Dream en självklar favorit i många år framöver. Det som skapar den mysiga känslan är en X-pocketresår i samarbete med en 5-zons pocketresår i den övre resårkärnan. Sängens övre pocketresår ger en helt individuell avlastning vilket minskar risken för tryck som gör att du vaknar och X-pocketresåren ger madrassen en extra ytmjuk känsla som bidrar till den omfamnande känslan. För en extra stabilitet i sängen har vi lagt till en kantförstärkning i övre resårkärnan. Den undre resårkärnan har en pocketresår som gör att du får ett extra djup i sängen och mycket god följsamhet. Sängen är svensktillverkad och finns i tre olika komforter, medium, fast eller extra fast. I priset ingår bäddmadrass Sense Delux och metallben.", "/images/products/c64b5527-307a-4e9b-a5be-d0805f6b99b4_0f7.jpg", "Dream Delux Ramsäng, enkelsäng med bäddmadrass Sense Delux", 10495m, 999 },
                    { 8, "Med sin följsamma och omfamnande känsla blir Dream en självklar favorit i många år framöver. Det som skapar den mysiga känslan är en X-pocketresår i samarbete med en 5-zons pocketresår i den övre resårkärnan. Sängens övre pocketresår ger en helt individuell avlastning vilket minskar risken för tryck som gör att du vaknar och X-pocketresåren ger madrassen en extra ytmjuk känsla som bidrar till den omfamnande känslan. För en extra stabilitet i sängen har vi lagt till en kantförstärkning i övre resårkärnan. Den undre resårkärnan har en pocketresår som gör att du får ett extra djup i sängen och mycket god följsamhet. Sängen är svensktillverkad och finns i tre olika komforter, medium, fast eller extra fast. I priset ingår bäddmadrass Sense Delux och metallben.", "/images/products/be42c2c5-bc3c-4c14-a959-e100bdb9eeab_188.jpg", "Dream Delux Ramsäng, enkelsäng med bäddmadrass Sense Delux", 10495m, 999 },
                    { 9, "Med sin följsamma och omfamnande känsla blir Dream en självklar favorit i många år framöver. Det som skapar den mysiga känslan är en X-pocketresår i samarbete med en 5-zons pocketresår i den övre resårkärnan. Sängens övre pocketresår ger en helt individuell avlastning vilket minskar risken för tryck som gör att du vaknar och X-pocketresåren ger madrassen en extra ytmjuk känsla som bidrar till den omfamnande känslan. För en extra stabilitet i sängen har vi lagt till en kantförstärkning i övre resårkärnan. Den undre resårkärnan har en pocketresår som gör att du får ett extra djup i sängen och mycket god följsamhet. Sängen är svensktillverkad och finns i tre olika komforter, medium, fast eller extra fast. I priset ingår bäddmadrass Sense Delux och metallben.", "/images/products/c64b5527-307a-4e9b-a5be-d0805f6b99b4_0f7.jpg", "Dream Delux Ramsäng, enkelsäng med bäddmadrass Sense Delux", 10495m, 999 },
                    { 10, "Med sin följsamma och omfamnande känsla blir Dream en självklar favorit i många år framöver. Det som skapar den mysiga känslan är en X-pocketresår i samarbete med en 5-zons pocketresår i den övre resårkärnan. Sängens övre pocketresår ger en helt individuell avlastning vilket minskar risken för tryck som gör att du vaknar och X-pocketresåren ger madrassen en extra ytmjuk känsla som bidrar till den omfamnande känslan. För en extra stabilitet i sängen har vi lagt till en kantförstärkning i övre resårkärnan. Den undre resårkärnan har en pocketresår som gör att du får ett extra djup i sängen och mycket god följsamhet. Sängen är svensktillverkad och finns i tre olika komforter, medium, fast eller extra fast. I priset ingår bäddmadrass Sense Delux och metallben.", "/images/products/be42c2c5-bc3c-4c14-a959-e100bdb9eeab_188.jpg", "Dream Delux Ramsäng, enkelsäng med bäddmadrass Sense Delux", 10495m, 999 },
                    { 11, "Bordlampa med LED-belysning och dimmer. Ljuskälla ingår. Cato LED ingår i en serie. Endast för inomhusbruk, kan ej användas i våtrum.", "/images/products/12337.jpg0", "Cato LED Bordslampa", 1871.25m, 999 },
                    { 12, "Vägglampa med LED-belysning och dimmer. Finns i flera olika utföranden.  Ljuskälla ingår. Cato LED ingår i en serie. Endast för inomhusbruk, kan ej användas i våtrum.", "/images/products/12173.jpg", "Cato LED Vägglampa", 1346.25m, 999 },
                    { 13, "Bordlampa med LED-belysning och dimmer. Ljuskälla ingår. Cato LED ingår i en serie. Endast för inomhusbruk, kan ej användas i våtrum.", "/images/products/12339.jpg", "Cato LED Bordslampa", 2471.25m, 999 },
                    { 14, "Tidlös golvlampa i metall med riktbar ljuskälla, anpassad för LED-lampa för lång brinntid.  Bra lampa för läsning. Ljuskälla LED 3x1 W ingår. Cato LED ingår i en serie. Endast för inomhusbruk, kan ej användas i våtrum.", "/images/products/11973.jpg", "Cato LED Golvlampa", 2471.25m, 999 },
                    { 15, "Bordlampa med LED-belysning och dimmer. Ljuskälla ingår. Cato LED ingår i en serie. Endast för inomhusbruk, kan ej användas i våtrum.", "/images/products/12340.jpg", "Cato LED Bordslampa", 1871.25m, 999 },
                    { 16, "Timeout är en unik fåtölj som är skräddarsydd just för dig. Fåtöljen har ett höj och sänkbart nackstöd samt en ledad rygg som följer ryggens form när du lutar dig tillbaka. Detta ger en maximal avlastning och ergonomisk vila i alla lägen vilket ökar blodcirkulationen. Du sätter själv din prägel på fåtöljens uttryck genom att bestämma klädsel och underrede. Välj mellan 300 olika läder, tyger och färger. Med 10 års garanti på stomme, sits och rygg blir fåtöljen än mer unik. Du kan även komplettera din fåtölj med en matchande fotpall.", "/images/products/20820.jpg", "Timeout Fåtölj", 14246.25m, 999 },
                    { 17, "Fotpallens vinkel passar fåtöljen Timeouts alla positioner, så att du får ett naturligt stöd oavsett längd. Du sätter själv din prägel på fåtöljen och fotpallens uttryck genom att bestämma klädsel och underrede. Välj mellan 300 olika läder, tyger och färger. Med 10 års garanti blir din Timeout än mer unik.", "/images/products/22501.jpg", "Timeout Fotpall", 3896.25m, 999 },
                    { 18, "Timeout är en unik fåtölj som är skräddarsydd just för dig. Fåtöljen har ett höj och sänkbart nackstöd samt en ledad rygg som följer ryggens form när du lutar dig tillbaka. Detta ger en maximal avlastning och ergonomisk vila i alla lägen vilket ökar blodcirkulationen. Du sätter själv din prägel på fåtöljens uttryck genom att bestämma klädsel och underrede. Välj mellan 300 olika läder, tyger och färger. Med 10 års garanti på stomme, sits och rygg blir fåtöljen än mer unik. Du kan även komplettera din fåtölj med en matchande fotpall.", "/images/products/20798.jpg", "Timeout Fåtölj", 14246.25m, 999 },
                    { 19, "Fotpallens vinkel passar fåtöljen Timeouts alla positioner, så att du får ett naturligt stöd oavsett längd. Du sätter själv din prägel på fåtöljen och fotpallens uttryck genom att bestämma klädsel och underrede. Välj mellan 300 olika läder, tyger och färger. Med 10 års garanti blir din Timeout än mer unik.", "/images/products/22336.jpg", "Timeout Fotpall", 3896.25m, 999 },
                    { 20, "Svensktillverkad fotpall som går att få i flera olika utföranden. Kompletteras till Life fåtölj.", "/images/products/92990.jpg00", "Life Fotpall", 3483.75m, 999 },
                    { 21, "Mjuk och lyxig matta i slitstark polyester som inte luddar. Trådarna i mattan varierar i nyans och lyster som ger mattan liv och ger rummet en trivsam och behaglig känsla. Fackmässig plantvätt.", null, "Madison Ryamatta", 2395m, 999 },
                    { 22, "Mjuk och lyxig matta i slitstark polyester som inte luddar. Trådarna i mattan varierar i nyans och lyster som ger mattan liv och ger rummet en trivsam och behaglig känsla. Fackmässig plantvätt.", "/images/products/192.jpg", "Madison Ryamatta", 2395m, 999 },
                    { 23, "Fotpallens vinkel passar fåtöljen Timeouts alla positioner, så att du får ett naturligt stöd oavsett längd. Du sätter själv din prägel på fåtöljen och fotpallens uttryck genom att bestämma klädsel och underrede. Välj mellan 300 olika läder, tyger och färger.", "/images/products/40603.jpg", "Timeout Fotpall", 2696.25m, 999 },
                    { 24, "Timeout är en unik fåtölj som är skräddarsydd just för dig. Fåtöljen har ett höj och sänkbart nackstöd samt en ledad rygg som följer ryggens form när du lutar dig tillbaka. Detta ger en maximal avlastning och ergonomisk vila i alla lägen vilket ökar blodcirkulationen. Du sätter själv din prägel på fåtöljens uttryck genom att bestämma klädsel och underrede. Välj mellan 300 olika läder, tyger och färger. Med 10 års garanti på stomme, sits och rygg blir fåtöljen än mer unik. Du kan även komplettera din fåtölj med en matchande fotpall.", "/images/products/40602.jpg", "Timeout Fåtölj", 9746.25m, 999 },
                    { 25, "Timeout är en unik recliner som är skräddarsydd just för dig. Reclinerfåtöljen har ett höj och sänkbart nackstöd samt en ledad rygg som följer ryggens form när du lutar dig tillbaka. Detta ger en maximal avlastning och ergonomisk vila i alla lägen vilket ökar blodcirkulationen. Du sätter själv din prägel på fåtöljens uttryck genom att bestämma klädsel och underrede. Välj mellan 300 olika läder, tyger och färger. Med 10 års garanti på stomme, sits och rygg blir din recliner än mer unik. Timeout finns även som fåtölj och fotpall.", "/images/products/20836.jpg", "Timeout Recliner", 14621.25m, 999 },
                    { 26, "Cord matbord är i lackerat ekfaner med dekorativa ribbor. Leon är en klädd stol med lätt vadderad dyna och ben i lackerad metall.", "/images/products/118413.jpg", "Cord Matgrupp med 4 stolar Leon", 13495m, 999 },
                    { 27, "Wilma matbord är ett riktigt genuint svenskt hantverk där materialen noga väljs ut av erfarna snickare, anpassas och sätts ihop för hand. Matbordet är tillverkat i björk och mdf som sedan handmålas i vit lasyr med pensel för att få den djupa och levande känslan av genuint hantverk. Bordsskivan finns i flera utföranden och är kan förlängas med 2 st tilläggsskivor, à 50 cm.", "/images/products/122785.jpg0", "Wilma Matgrupp med 6 stolar", 29995m, 999 },
                    { 28, "Sittbänk med stoppad pikerad topp, som blir en fin detalj till sängen och erbjuder praktisk förvaring i sovrummet. Perfekt för att förvara ett extra täcke och kudde eller annat som du behöver stoppa undan. Bänken kommer i tyg Noa eller sammetstyg Macy. I priset ingår 112 cm ben.", "/images/products/6ce072_258571_a025b7_76f7b4_faef9d_74fd29_cf7132_db3f64_204a46_06b.jpg", "Energy Sittbänk", 6495m, 999 },
                    { 29, "Wilma matbord är ett riktigt genuint svenskt hantverk där materialen noga väljs ut av erfarna snickare, anpassas och sätts ihop för hand. Matbordet är tillverkat i björk och mdf som sedan handmålas i vit lasyr med pensel för att få den djupa och levande känslan av genuint hantverk. Bordsskivan finns i flera utföranden och är kan förlängas med 2 st tilläggsskivor, à 50 cm.", "/images/products/50009.jpg", "Wilma Matgrupp med 6 stolar", 35795m, 999 },
                    { 30, "Sov gott och vakna upp utvilad i Energy. Den svensktillverkade sängserien består av noga utvalda komponenter som bidrar till den höga komforten. Fjädrarna i Energy är konvexa och optimalt förspända som innebär att ett maximalt stöd uppnås. Pocketkärnan är uppdelad i 3 zoner som är utformade för att ge individuell fjädring för mycket god tryckavlastning och följsamhet. Sängens undre kärna är uppbyggd med en fast pocketkärna, 13 cm hög. En 8 cm hög träram finns längst ner på sängen för en stadig bas. På toppen ligger bäddmadrassen som är stoppad med soft skum. Välj mellan komforten medium, fast eller extra fast och finns i sammets- eller möbeltygsklädsel. Madrassen i mitten består av två kassetter som läggs i ett tygfodral.", "/images/products/6ce072_e1526e_a025b7_50c9db_faef9d_d3e1e1_cf7132_db3f64_4a1e02_2a9.jpg", "Energy Kontinentalsäng, dubbelsäng med bäddmadrass Energy", 28995m, 999 },
                    { 31, "Lucas är ett matbord i tåligt laminat med underrede i lackerat trä. Laminat står sig bättre emot repor och vätskor jämfört med en lackad yta. Einar är en traditionell pinnstol i massivt trä med en lackerad yta.", "/images/products/105849.jpg", "Lucas Matgrupp med 4 stolar Einar", 6795m, 999 },
                    { 32, "Sharp är ett bord i laminat som är extra tålig och mer beständig mot repor och vätskor. Benen är i lackerad metall.", "/images/products/103023.jpg", "Sharp Matbord, Ø 110 cm", 3095m, 999 },
                    { 33, "Wilma matbord är ett riktigt genuint svenskt hantverk där materialen noga väljs ut av erfarna snickare, anpassas och sätts ihop för hand. Matbordet är tillverkat i björk och mdf som sedan handmålas i vit lasyr med pensel för att få den djupa och levande känslan av genuint hantverk. Bordsskivan finns i flera utföranden och är kan förlängas med 2 st tilläggsskivor, à 50 cm.", "/images/products0/50307.jpg", "Wilma Matgrupp med 6 stolar", 35795m, 999 },
                    { 34, "En karaktäristisk takpendel som med sina skira glaskupor ger ett mjukt men ändå vågat uttryck. Men Grapes är inte bara attityd, när ljuset silas genom de tonade glaset bildas ett mjukt och stämningsfullt ljus i rummet. Köp gärna till någon av våra passande ljuskällor.", "/images/products/42763.jpg", "Grapes Taklampa", 2246.25m, 999 },
                    { 35, "Stilren handvävd ullmatta med läderkant. Ullen gör mattan naturligt smutsavvisande och slitstark. Då mattan är handvävd samt att läderkanten är påsydd för hand, är varje matta unik. Skarvar kan även förekomma på läderkanten. Grimsby är en lättmatchad och snygg matta som också är vändbar vilket ger den en lång livslängd. Köp gärna till vårt mattunderlägg. Kemtvätt.", "/images/products/69941.jpg", "Grimsby Ullmatta", 1046.25m, 999 },
                    { 36, "Mjuk och härlig lammskinnsfäll som blir en dekorativ detalj i soffan eller hängandes över en stolsrygg. Använd en lätt fuktad tvättsvamp eller klädvårdsrulle över ytan för att samla ihop eventuellt damm och smuts. ", "/images/products/56449.jpg", "Isak Lammskinn", 349m, 999 },
                    { 37, "Ullrika är en len och värmande fårskinnsdyna. Använd en lätt fuktad tvättsvamp eller klädvårdsrulle över ytan för att samla ihop eventuellt damm och smuts.", "/images/products/94429.jpg", "Ulrika Stolsdyna, Ø 34 cm", 99m, 999 },
                    { 38, "Ritz är en serie badtextil med exklusiv hotellkänsla, tillverkad med ett så kallat Air rich-framtagande. Air rich innebär att handduken är vävd i 100% bomull tillsammans med vattenlösliga fibrer. I slutprocessen sköljs de överflödiga fibrerna bort vilket ger en luftig och mycket mjuk handduk, tvätt efter tvätt. Dessutom är handdukarna Oeko-Tex certifierade och är därmed extra snälla mot din hud och miljön. Ritz tvättas enkelt i 60°C maskintvätt.", "/images/products/85822.jpg", "Ritz Badlakan, 90x150 cm", 499m, 999 },
                    { 39, "Mjuk badrock i bomullsvelour. Ritz har stort slag vid ärmslut, vida ärmar och två fickor fram. Badrocken stängs med knytband i midjan.\r\nLängd: 130 cm,\r\nArmlängd: 54 cm,\r\nBredd över axlar: 61 cm,\r\nBredd över bröstet: 63,5 cm,\r\nLängd knytband: 203 cm", "/images/products/138182.jpg", "Ritz Badrock, L/XL", 999m, 999 },
                    { 40, "Fårskinnstofflor som går att använda året om då de är gjorda i ett naturligt material. Ullen har bland annat temperaturreglerande egenskaper som gör att de håller dina fötter svala under varma dagar och skänker värme när det är kallt. Är du en person som har besvär med kalla fötter så är detta ett bra alternativ, som dessutom är fina att titta på. Tofflorna finns i storlek 42-43 och 44-45.", "/images/product00s/144495.jpg", "Trysil Tofflor, fårskinn kastanj/vit, 1 par", 399m, 999 },
                    { 41, "Sannäs är ett härligt täcke med fyllning av microfiber och hålfiber, yttertyg i 100% bomullscambric. Hålfibern innehåller luft som i sin tur är en bra isolering och transporterar effektivt bort fukt från kroppen som bidrar till bättre sovklimat och komfort. För din och miljöns skull är Sannäs OEKO-TEX®-certifierad produkt Tvättas i 60°C och torktumlas på låg värme.", "/images/products/47062.jpg", "Sannäs Fibertäcke, 230x220 cm, svalt", 899m, 999 },
                    { 42, "Meja är en pläd i mjuk och skön pälsimitation. Pläden är tillverkad i 100% polyester, OEKO-TEX®-certifierad produkt och kan tvättas i 30°C skontvätt.", "/images/products/129580.jpg", "Meja Pläd, 130x170 cm", 599m, 999 },
                    { 43, "Din kropp alstrar sin egen värme. Så om du svettas eller fryser beror både på vem just du är och på temperaturen i rummet, Cecilia från EngmoDun finns i flera varianter beroende på hur svalt eller varmt du vill ha ditt täcke. Naturmaterial andas och håller kvar lagom mycket värme, men släpper igenom överskottet.\r\n\r\nCecilia kuddar och täcken är fyllt med naturligt, nästan viktlöst finaste mysk anddun för att ge den optimala sovkomforten. Maskintvätt 60 °C. med ett skonsamt tvättmedel, och torka i torktumlare. Skaka om täcket eller kudden och känn efter om det känns torrt och doftar friskt, då är det klart att användas igen. Vädra och lufta gärna ditt täcke ofta för att bibehålla den luftiga och lätta känslan. Täcket levereras i en fin tygpåse, tänk på att det legat rullpackad och kan behöva någon dag på sig att återfå sin form.", "/images/products/109470.jpg", "EngmoDun Cecilia Duntäcke, 150x210 cm, varmt", 2795m, 999 },
                    { 44, "Färgstarka motiv med en personlig karaktär är det som kännetecknar konstnären Carolina Gynnings verk. Varje motiv förmedlar ett eget budskap med inspiration från livets pågående skeenden. Vinglaset finns med flera motiv som är fina att duka med tillsammans.", "/images/products/42860.jpg", "Carolina Gynning Rödvinsglas, 75 cl", 269m, 999 },
                    { 45, "Daga är ett dricksglas inspirerad av vardagen där funktionalitet och enkelhet möts. Vattenglaset i randigt klarglas blir snabbt en favorit med sin behändiga storlek och stilrena design. Glasen är dessutom stapelbara och tar därför inte mycket plats när de inte används.", "/images/products/70063.jpg", "Daga Glas, 4-pack, 25,5 cl", 0m, 999 },
                    { 46, "Vilgot är en möbelserie i retroinspirerad skandinavisk stil. Detaljerna med lätt utställda ben och raka former är det som sätter prägeln för serien. Matbordet är förberett för att kompletteras med två tilläggsskivor à 45 cm. Tilläggsskiva säljs separat.", "/images/products/118907.jpg", "Vilgot Matbord, L 200 cm", 7995m, 999 },
                    { 47, "Exklusiv sovkudde med spänstig bollfiber som gör att kudden håller sin form under natten och ger ett effektivt stöd under sömnen. Kudden är omsluten av yttertyg i 100% bomullscambric.", "/images/products/135197.jpg", "Höie Dreamnight Fiberkudde, 50x60 cm, mellan", 174m, 999 },
                    { 48, "Denna klassiska kudde är tillverkad i ett speciellt utvecklat Tempur extra soft-material för att erbjuda en fin balans mellan mjukhet och stöd. Den är perfekt för dig som vill ha det stöd som Tempur erbjuder, med en mjukare kramgo känsla. Formad som en traditionell kudde, passar den de flesta sovställningar. Fodralet kan maskintvättas i 40°C.", "/images/products/6290.jpg", "Tempur Cloud Funktionskudde, 50x60 cm, mjuk", 2195m, 999 },
                    { 49, "Särö är en klädd sänggavel i välvd modell som blir ett fint komplement till din Särö säng. Den är klädd i ett slitstarkt tyg med möbelkänsla som ger en ombonad känsla i sovrummet. Sänggaveln är mjuk och skön att luta sig mot när du vill sitta i sängen och läsa eller se på TV. Till sänggaveln ingår ben, höjd 12 cm. Totalhöjd på gavel med ben är 149 cm.", "/images/products/130205.jpg", "Särö välvd Sänggavel, B 160-210 cm", 8995m, 999 },
                    { 50, "Särö är en klädd sänggavel i pikerad modell som blir ett fint komplement till din Särö säng. Den är klädd i ett slitstarkt tyg med möbelkänsla som ger en ombonad känsla i sovrummet. Sänggaveln är mjuk och skön att luta sig mot när du vill sitta i sängen och läsa eller se på TV. Till sänggaveln ingår ben, höjd 12 cm. Totalhöjd på gavel med ben är 137cm.", "/images/products/130100.jpg", "Särö pikerad L Sänggavel, B 90-120 cm", 7995m, 999 },
                    { 51, "Luca är en hatthylla i lackerad metall med utmärkande detaljer och tre praktiska krokar. Kombinera gärna med andra delar i serien för att få till en enhetlig klädförvaring.", "/images/products/69359.jpg", "Luca Hatthylla, B 70 cm", 899m, 999 },
                    { 52, "Magaluf är ett stilsäkert runt matbord i konstrotting av god kvalitet. Bordet har en stomme i aluminium och konstrotting och en skiva i konstträ. Bordet är både underhållsfritt och tåligt. Alla våra flätade utemöbler är handgjorda och gör varje möbel unik i utseende och färg. Ta hand om dina möbler så håller de längre, se dokument för skötselråd för produkten.", "/images/products/68194.jpg", "Magaluf Utebord, Ø 150 cm", -6995m, 999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);
        }
    }
}
