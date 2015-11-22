//
//  InterViewedTableViewCell.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/22/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "InterViewedTableViewCell.h"
#import "Candidate.h"
@implementation InterViewedTableViewCell

- (void)awakeFromNib {
    // Initialization code
}

- (void)setSelected:(BOOL)selected animated:(BOOL)animated {
    [super setSelected:selected animated:animated];

    // Configure the view for the selected state
}
- (void)setupCell:(Candidate *)candidateItem
{
    [super setupCell:candidateItem];
    self.lblActual.text =  [NSString stringWithFormat:@"%ld %%",(long)candidateItem.actualScore];
    
    
}
- (void)layoutSubviews
{
    [super layoutSubviews];
    float score = ((float)self.candidate.actualScore / 170.0) *100;
    
   self.uivtualScore.frame = CGRectMake(106.0, 57.0, score, 8.0);
    
    
}
@end
