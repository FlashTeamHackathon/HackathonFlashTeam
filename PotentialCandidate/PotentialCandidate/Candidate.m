//
//  Candidate.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "Candidate.h"

@implementation Candidate

- (id)initWith:(NSString *)fullName des:(NSString *)des
    experience:(NSInteger )experience major:(NSString *)major jobTitle:(NSString *)jobTitle imageAvartar:(NSString *)imageAvartar school:(NSString *)school isMale:(BOOL)isMale isAppliedInterview:(BOOL)isAppliedInterview idCandidate:(NSString *)idCandidate score:(NSInteger)score phoneNumber:(NSString *)phoneNumber address:(NSString *)address
{

    if(self = [super init])
    {
        self.fullName  = fullName;
        self.des = des;
        self.experience = experience;
        self.major = major;
        self.jobTitle  = jobTitle;
        self.imageAvartar = imageAvartar;
        self.school = school;
        self.isMale = isMale;
        self.isAppliedInterview = isAppliedInterview;
        self.idCandidate = idCandidate;
        self.score = score;
        self.phoneNumber = phoneNumber;
        self.address = address;
        
    }
    return self;
}
@end
