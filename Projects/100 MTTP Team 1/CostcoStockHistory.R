library(tidyverse)
library(readxl)
library(readr)
dfn <- read.csv("/Users/abearcher/Spring2024/DASC1223H/COST.csv")
dfn$Datenew <- as.Date(dfn$Date)
dfn
ggplot(dfn, aes(x = Datenew, y = Close)) + geom_line(color = "firebrick"
  ) + labs(x = "Year", y = "Costco Stock Price"
  ) + ggtitle("Coscto Stock 2009-2019"
  ) + theme(plot.title = element_text(size=30, face="bold", margin = margin(20, 20, 10, 0))
  ) + theme(axis.title.x = element_text(face = "bold", size = 15, vjust=-0.85),axis.title.y = element_text(face = "bold", size = 15, vjust=1.05)   
  ) + theme(plot.title = element_text(hjust = 0.3))
